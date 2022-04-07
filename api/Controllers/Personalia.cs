using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using api.DAL.code;
using api.DAL.dtos;
using api.DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Authorize]
    public class Personalia : Controller
    {
        private readonly ILogger<Personalia> _logger;
        private IPersonalia _pers;
        private SpecialMaps _special;

        public Personalia(ILogger<Personalia> logger, IPersonalia pers, SpecialMaps special)
        {
            _logger = logger;
            _pers = pers;
            _special = special;
        }

        [HttpGet]
        [Route("api/getPersonalia/{id}")]
        public async Task<IActionResult> getP001(int id)
        {
            var help = await _pers.getPer(id);
            return Ok(_special.mapPersonaliaForReturn(help));
        }
        [HttpPost]
        [Route("api/updatePersonalia")]
        public async Task<IActionResult> getP002(personaliaForReturnDto pd)
        {
            var help = "error saving";
           if(await _pers.savePer(pd)){help = "Saved";};

            return Ok(help);
        }


    }
}