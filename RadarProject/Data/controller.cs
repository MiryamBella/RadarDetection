// CustomersController.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace radar_project
{
    [ApiController] // NOTE: for a REST API controller
    [Route("[radar]")] // could be [Route("api/[radar]")]
    public class CustomersController : ControllerBase
    {
        [HttpPost] // CREATE
        public void Post([FromBody] Globel g) // NOTE: [FromBody] specifies that "item" be parsed from the request body
        {
            Processor pro = new Processor()
            pro.radar_and_picture(g.Pixels, g.Drones)
        }
    }
}