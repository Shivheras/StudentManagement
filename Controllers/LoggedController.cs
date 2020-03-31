using Microsoft.AspNetCore.Mvc;
using StudentCourse.Domains;
using StudentCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoggedController : ControllerBase
    {
            public LoggedController()
            {
                this.StudentDomain = new StudentDomain();
            }
        [HttpPost]
        public IActionResult Post(Students student)
        {
            StudentDomain.IsLogin(student);
            return Ok();
        }
        private StudentDomain StudentDomain { get; set; }
    }
}
