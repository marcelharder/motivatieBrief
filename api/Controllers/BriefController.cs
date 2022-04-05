using System.Threading.Tasks;
using api.DAL.code;
using api.DAL.Interfaces;
using api.DAL.models;
using Cardiohelp.data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cardiohelp.Controllers
{
    [ApiController]
    [Authorize]
    public class BriefController : ControllerBase
    {
       private IUser _user;
        private SpecialMaps _special;

        private IBrief _brief;
         
        public BriefController(IUser user, SpecialMaps special, IBrief brief)
        {
            _user = user;
            _special = special;
            _brief = brief;
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
            if(help){return Ok();}
  
            return BadRequest("Problem saving the brief");
        }


    }
}