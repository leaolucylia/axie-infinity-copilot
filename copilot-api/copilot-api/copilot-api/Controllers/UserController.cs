﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace copilot_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {

        }
    }
}
