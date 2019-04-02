﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Meblex.API.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController: ControllerBase
    {

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Auth()
        {
            return Ok();
        }
        
    }
}