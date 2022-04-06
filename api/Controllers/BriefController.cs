using System.Threading.Tasks;
using api.DAL.code;
using api.DAL.dtos;
using api.DAL.Interfaces;
using api.DAL.models;
using Cardiohelp.data.Interfaces;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Cardiohelp.Controllers
{
    [ApiController]
    [Authorize]
    public class BriefController : ControllerBase
    {
       private IUser _user;
        private SpecialMaps _special;

        private readonly IOptions<api.Helpers.CloudinarySettings> _cloudinaryConfig;
        private Cloudinary _cloudinary;


        private IBrief _brief;
         
        public BriefController(IUser user, 
        SpecialMaps special,
         IBrief brief,  
         IOptions<api.Helpers.CloudinarySettings> cloudinaryConfig)
        {
            _user = user;
            _special = special;
            _brief = brief;

            _cloudinaryConfig = cloudinaryConfig;
          

            Account acc = new Account(
                _cloudinaryConfig.Value.CloudName,
                _cloudinaryConfig.Value.ApiKey,
                _cloudinaryConfig.Value.ApiSecret
            );
            _cloudinary = new Cloudinary(acc);
        } 

        [HttpGet]
        [Route("api/getBrief/{userid}")]
        public async Task<IActionResult> GetAsync(int userid)
        {
            var help = await _brief.getBrief(userid);

            if(help == null){return BadRequest("Problem getting brief ...");}
            
            return Ok(_special.mapToBriefForReturn(help));
        }

        [HttpPost]
        [Route("api/updateBrief")]
        public async Task<IActionResult> Post(Brief br)
        {
            var help = await _brief.saveBrief(br);
            if(help){return Ok(help);}
  
            return BadRequest("Problem saving the brief");
        }

        [HttpPost]
        [Route("api/addBriefPhoto/{id}")]
        public async Task<IActionResult> PostPhoto(int id,PhotoForCreationDto photoDto)
        {

            var br = await _brief.getBrief(id);

            var file = photoDto.file;
            var uploadResult = new ImageUploadResult();
            if (file.Length > 0)
            {
                using (var stream = file.OpenReadStream())
                {
                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(file.Name, stream),
                        Transformation = new Transformation().Width(500).Height(500).Crop("fill").Gravity("face")
                    };
                    uploadResult = _cloudinary.Upload(uploadParams);
                }
                br.PhotoUrl = uploadResult.Uri.ToString();

                if (await _brief.SaveAll())
                {
                    
                    return Ok(br);
                }

            }
            return BadRequest("Could not add the photo ...");

        }


    }
}