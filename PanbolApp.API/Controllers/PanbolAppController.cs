using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PanbolApp.Core.Dto;
using PanbolApp.Core.Interfaces.Repository;
using Serilog;

namespace PanbolApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PanbolAppController : ControllerBase
    {
        private readonly IPanbolAppRepository _panbolAppRepository;

        public PanbolAppController(IPanbolAppRepository panbolAppRepository)
        {
            _panbolAppRepository = panbolAppRepository;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(GamerCard), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _panbolAppRepository.GetGamers());
            }
            catch (Exception ex)
            {
                Log.Error("GetGamers: {error}", ex.ToString());
                return Problem(ex.Message, null, null, null, null);
            }
        }
    }
}
