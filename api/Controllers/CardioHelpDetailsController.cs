using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using api.DAL.code;
using api.DAL.data;
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
    public class CardioHelpDetailsController : ControllerBase
    {
        private ICardioRepository _repo;
        private IUser _user;
        private SpecialMaps _special;

        public CardioHelpDetailsController(ICardioRepository repo, SpecialMaps special, IUser user)
        {
            _repo = repo;
            _special = special;
            _user = user;
        }

        


        [Route("api/CardiohelpDetails/{id}", Name = "getCardioHelp")]
        public async Task<IActionResult> getCardioHelpDetailsAsync(int id)
        {
            var help = await _repo.getCardioDetails(id);
            return Ok(_special.mapToCardioDetails(help));
        }

        [Route("api/CardiohelpDetailsFromCassette/{cassetteid}")]
        public async Task<IActionResult> getCardioHelpDetailsAsync(string cassetteid)
        {
            return Ok(await _repo.getCardioDetailsFromCassette(cassetteid));
        }

        [Route("api/getRecordAvailable/{id}")]
        public async Task<IActionResult> getRecordAvailableAsync(string id)
        {
            var findresult = "";
            findresult = await _repo.findCardio(id);
            return Ok(findresult);
        }

        [Route("api/addNewRecord/{cassette_id}")]
        public async Task<IActionResult> getNewRecordAsync(string cassette_id)
        {
            var currentUserId = _special.getCurrentUserId();
            var currentuser = await _user.getUserDetails(currentUserId);

            var help = new Cardio();
            help.cassette_id = cassette_id;
            // some sensible defaults go here
            help.center_id = currentuser.center_id;
            help.contributor_id = currentuser.contributor_id;
            help.patient_gender = 0;
            help.indication = 0;
            help.support_mode = 0;



            help.start = DateTime.Now;
            help.start_hour = DateTime.Now.Hour;
            help.start_min = DateTime.Now.Minute;


            _repo.Add(help);
            if (await _repo.SaveAll())
            {
                var helpToReturn = _special.mapToCardioDetails(help);
                return CreatedAtRoute("getCardioHelp", new { Id = help.Id }, helpToReturn);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("api/updateRecord/{userId}")]
        public async Task<IActionResult> PostAsync(int userId, CardioDetailsDTO td)
        {
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (currentUserId != userId) return Unauthorized();

            var c = await _repo.getCardioDetails(td.Id);
            Cardio test = _special.mapToCardio(td, c);
            
            _repo.Update(test);

            if (await _repo.SaveAll()) { return Ok("updated ..."); }
            return BadRequest();
        }

        [HttpGet]
        [Route("api/getRegistryList/{userId}")]
        public async Task<IActionResult> GetRegistriesForUser(int userId, [FromQuery] CardioParams p)
        {
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (currentUserId != userId) return Unauthorized();
            var messagesFromRepo = await _repo.GetCardios(p);
            var messages = _special.mapToListOfmessageToReturnFromListOfMessageAsync(messagesFromRepo);
            Response.AddPagination(messagesFromRepo.Currentpage,
            messagesFromRepo.PageSize,
            messagesFromRepo.TotalCount,
            messagesFromRepo.TotalPages);
            return Ok(messages);
        }

    }
}