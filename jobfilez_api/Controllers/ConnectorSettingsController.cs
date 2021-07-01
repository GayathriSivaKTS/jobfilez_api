using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobfilez_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectorSettingsController : ControllerBase
    {
        private readonly IConnectorSettingsService connectorsettingservice;

        public ConnectorSettingsController(IConnectorSettingsService connectorsettingservice)
        {
            this.connectorsettingservice = connectorsettingservice;
        }

        [HttpGet]
        public async Task<ActionResult> GetConnectorSettings()
        {
            try
            {
                return Ok(await connectorsettingservice.GetConnectorSettings());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
