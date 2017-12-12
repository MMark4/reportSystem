namespace reportsystemwebapi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Models;

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ReportSystemDBContext _context;

        public ValuesController(ReportSystemDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TestCycle> GetTestCycles()
        {
            return _context.GetTestCycles();
        }
    }
}