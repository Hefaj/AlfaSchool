using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AlfaSchool.Repository.DbAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlfaSchool.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            return NotFound();
        }
        
        // GET: api/TodoItems/guid
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Student>> Get(Guid id)
        {
            return null;
        }
        
        // POST
        [HttpPost]
        public async Task<ActionResult> Add([FromBody] Student student)
        {
            return null;
        }
    }
}