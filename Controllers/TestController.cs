using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTest.Models;

namespace BugTest.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly IFreeSql _testDB;

        public TestController(ILogger<TestController> logger,IFreeSql testDB)
        {
            _logger = logger;
            _testDB = testDB;
        }

        [Route("/test")]
        [HttpGet]
        public IActionResult Get()
        {
            var selectParams = "id,name,is_enabled,is_abc,a_number,a_text,text2,bool2";
            var result = _testDB.Select<Test>()
                                .Where(t => t.Id == 1)
                                .ToList<Test>(selectParams);

            return new JsonResult(result[0]);
        }
    }
}
