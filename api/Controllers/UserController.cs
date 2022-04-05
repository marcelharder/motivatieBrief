using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using Cardiohelp.data.Interfaces;
using api.DAL.code;
using api.DAL.dtos;
using api.DAL.helpers;
using api.DAL.models;
using Microsoft.Extensions.Options;
using api.Helpers;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using api.DAL.Interfaces;

namespace Cardiohelp.Controllers
{
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private IUser _user;
        private SpecialMaps _special;
        private Cloudinary _cloudinary;

        private IBrief _br;
        private readonly IOptions<CloudinarySettings> _cloudinaryConfig;

        public UserController(IUser user, SpecialMaps special, IOptions<CloudinarySettings> cloudinaryConfig, IBrief br)
        {
            _user = user;
            _special = special;
            _br = br;
            _cloudinaryConfig = cloudinaryConfig;

            Account acc = new Account(
              _cloudinaryConfig.Value.CloudName,
              _cloudinaryConfig.Value.ApiKey,
              _cloudinaryConfig.Value.ApiSecret
          );
            _cloudinary = new Cloudinary(acc);
        }
        [HttpGet]
        [Route("api/getUserByEmail/{email}")]
        public async Task<UserForReturnDto> GetAsync(string email)
        {
            var help = await _user.getUserByEmail(email);
            return await _special.mapToUserForReturnAsync(help);
        }


        [HttpGet]
        [Route("api/getUser/{id}", Name = "GetUser")]
        public async Task<UserForReturnDto> GetAsync(int id)
        {
            var help = await _user.getUserDetails(id);
            return await _special.mapToUserForReturnAsync(help);
        }

        [HttpPut]
        [Route("api/updateUser/{id}")]
        public async Task<IActionResult> PutAsync(int id, UserForUpdateDto td)
        {
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (currentUserId != id) return Unauthorized();

            var user_before = await _user.getUserDetails(td.Id);
            _user.Update(_special.mapToUserAsync(td, user_before));
            if (await _user.SaveAll()) { return Ok("updated ..."); } else { return BadRequest(); }
        }

        [HttpGet]
        [Route("api/getListOfUsers")]
        public async Task<IActionResult> Get([FromQuery] UserParams userParams)
        {
            var values = await _user.GetUsers(userParams);
            var l = new List<UserForReturnDto>();
            foreach (User us in values)
            {
                l.Add(await _special.mapToUserForReturnAsync(us));
            }
            Response.AddPagination(values.Currentpage, values.PageSize, values.TotalCount, values.TotalPages);
            return Ok(l);
        }

        [HttpGet]
        [Route("api/getListOfUsersPerCenter")]
        public async Task<IActionResult> GetPerCenter([FromQuery] UserParams userParams)
        {
            var values = await _user.GetUsersPerCenter(userParams);
            var l = new List<UserForReturnDto>();
            foreach (User us in values)
            {
                l.Add(await _special.mapToUserForReturnAsync(us));
            }
            Response.AddPagination(values.Currentpage, values.PageSize, values.TotalCount, values.TotalPages);
            return Ok(l);
        }

        [HttpDelete]
        [Route("api/deleteUser/{id}/{userId}")]
        public async Task<IActionResult> DeleteUser(int id, int userId)
        {
            if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)) return Unauthorized();
            var user = await _user.getUserDetails(userId);
            _user.Delete(user);
            if (await _user.SaveAll()) return Ok("User deleted ...");
            return BadRequest("Deleting failed ...");
        }

        [HttpGet]
        [Route("api/addUser/{un}")]
        public async Task<IActionResult> addUser(string un)
        {
            var user = new User();
            user.username = un.ToLower();
            user.user_role = "normal";
            // get the login and password now
            byte[] passwordHash, passwordSalt;
            CreatePassWordHash("password", out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            _user.Add(user);
            if (await _user.SaveAll())
            {
                UserForReturnDto ufr = await _special.mapToUserForReturnAsync(user);
                return CreatedAtRoute("GetUser", new { id = user.Id }, ufr);
            }
            return BadRequest("Could not add a new User ...");
        }


        [HttpPost]
        [Route("api/addUserPhoto/{un}")]
        public async Task<IActionResult> AddPhotoForUser(int id, [FromForm] PhotoForCreationDto photoDto)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)) return Unauthorized();
            
            var user = await _user.getUserDetails(id);

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
                user.photoUrl = uploadResult.Uri.ToString();



                if (await _user.SaveAll())
                {
                    UserForReturnDto ufr = await _special.mapToUserForReturnAsync(user);
                    return CreatedAtRoute("GetUser", new { id = user.Id }, ufr);
                }

            }
            return BadRequest("Could not add the photo ...");
        }

        private void CreatePassWordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA1())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            };
        }

    }
}