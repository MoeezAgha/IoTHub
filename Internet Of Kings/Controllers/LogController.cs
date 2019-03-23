using System;
using System.Linq;
using InternetOfKings.EntityFramework;
using InternetOfKings.Enums;
using InternetOfKings.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InternetOfKings.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly InternetOfKingsContext _context;

        public LogController(InternetOfKingsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(LogInformationEnum? type = null)
        {
            var logInformation = _context.LogInformations.AsNoTracking();
            if (type != null) logInformation = logInformation.Where(l => l.Type == type);
            return Ok(logInformation);
        }

        [HttpPost]
        public IActionResult Post([FromBody] LogInformation logInformation)
        {
            if (!ModelState.IsValid) return BadRequest();
            if (logInformation.Time == DateTime.MinValue) logInformation.Time = DateTime.Now;
            var newLogInformation = _context.LogInformations.Add(logInformation);
            _context.SaveChanges();
            return Ok(newLogInformation.Entity);
        }
    }
}