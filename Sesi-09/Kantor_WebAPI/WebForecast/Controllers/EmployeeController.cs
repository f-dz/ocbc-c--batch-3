using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebForecast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebForecast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        //GET api/user
        [HttpGet (Name = "Get")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            //return new string[]
            return _context.GetAllEmployee();
        }

        //GET : api/user/{id}
        [HttpGet("{id}", Name = "Get where")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            //return new string[]
            return _context.GetEmployee(id);
        }

    }
}
