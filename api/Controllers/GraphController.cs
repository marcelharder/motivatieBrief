using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using api.DAL.code;
using api.DAL.Interfaces;
using Cardiohelp.data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cardiohelp.Controllers
{
    [ApiController]
    [Authorize]
    public class GraphController : ControllerBase
    {

        private ICardioRepository _repo;
        private IUser _user;
        private SpecialMaps _special;
        private CSVProducer _prod;

        public GraphController(ICardioRepository repo, SpecialMaps special, IUser user, CSVProducer prod)
        {
            _repo = repo;
            _special = special;
            _user = user;
            _prod = prod;
        }

        [HttpGet("api/users/{userId}/isHemoFileAvailable/{registryId}")]
        public async Task<IActionResult> getHemoFilePresent(int userId, int registryId)
        {
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (currentUserId != userId) return Unauthorized();

            var selectedCardioRecord = await _repo.getCardioDetails(registryId);
            if (await _repo.isHemoFilePresent(registryId)) { return Ok("found"); }
            else { return BadRequest("No hemodynamics file found"); }
        }

        [HttpGet("api/users/{userId}/csv/{registryId}/parameter/{p}")]
        public async Task<IActionResult> getTemp(int userId, int registryId, int p)
        {
            byte[] bytes;
            
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (currentUserId != userId) return Unauthorized();
            
            var selectedCardioRecord = await _repo.getCardioDetails(registryId);
            bytes = selectedCardioRecord.hemodynamics;
            _prod.rehydrateByte(bytes);
            switch (p)
            {
                case 1: return Ok(_prod.getPart());
                case 2: return Ok(_prod.getPint());
                case 3: return Ok(_prod.getSvO2());
                case 4: return Ok(_prod.getTemp());
            }
            return BadRequest();
        }





    }
}