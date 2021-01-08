using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using api.DAL.code;
using api.DAL.dtos;
using api.DAL.helpers;
using api.DAL.Interfaces;
using Cardiohelp.data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cardiohelp.Controllers
{
    [ApiController]
    [Authorize]
    public class HemodynamicsController : ControllerBase
    {
        private IUser _user;
        private ICardioRepository _repo;

        private SpecialMaps _special;
        private ICardioRepository _cardio;
        public HemodynamicsController(
        IUser user,
        ICardioRepository cardio,
        SpecialMaps special,
        ICardioRepository repo)
        {
            _user = user;
            _cardio = cardio;
            _repo = repo;
            _special = special;
        }

        [HttpGet("{id}")]
        [HttpGet("api/hemodynamics/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var record = await _repo.getCardioDetails(id);
            return Ok(_special.mapToHemoForReturn(record));
        }

        [HttpPost]
        [Route("api/users/{userId}/hemoFile/{id}")]
        public async Task<IActionResult> uploadFile(int userId, int id, [FromForm] HemoForCreationDto h)
        {

            var result = "";
            var user = await _user.getUserDetails(userId);
            if (user == null) return BadRequest("Could not find user");
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (currentUserId != user.Id) return Unauthorized();



            if (h.file.Length > 0)
            {
                // save the hemodynamics file to the database
                result = await _cardio.updateHemodynamicsFile(id, await h.file.GetBytes());
            }


            return Ok(result);
        }

        [HttpDelete]
        [Route("api/users/{userId}/hemoFile/{id}")]
        public async Task<IActionResult> deleteFile(int userId, int id)
        {

            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (currentUserId != userId) return Unauthorized();

            var selectedCardioRecord = await _cardio.getCardioDetails(id);
            selectedCardioRecord.hemodynamics = new byte[0];

            _cardio.Update(selectedCardioRecord);
            if (await _cardio.SaveAll()) { return Ok("Deleted ..."); } else { return BadRequest(); }
        }


    }
}
