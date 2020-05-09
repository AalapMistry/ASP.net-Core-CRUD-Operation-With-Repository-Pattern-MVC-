using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service.Employee;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AalapCRUDWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [DisableCors]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _iemployeeService;

        public EmployeeController(IEmployeeService iEmployeeService)
        {
            _iemployeeService = iEmployeeService;
        }


        // GET: api/Employees
        [HttpGet]
        public async Task<IList<EmployeeModel>> Gettblemployee()
        {
            IList<EmployeeModel> EmpList = new List<EmployeeModel>();
            EmpList = await _iemployeeService.GetAllEmployees();
            return EmpList;
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employee = await _iemployeeService.GetEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee([FromRoute] int id, [FromBody] EmployeeModel employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.ID)
            {
                return BadRequest();
            }
            await _iemployeeService.UpdateEmployee(employee);

            return NoContent();
        }

        // POST: api/Employees
        [HttpPost]
        public async Task<IActionResult> PostEmployee([FromBody] EmployeeModel employee)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _iemployeeService.AddEmployee(employee);

            return CreatedAtAction("GetEmployee", new { id = employee.ID }, employee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _iemployeeService.DeleteEmployee(id);
            
            return Ok();
        }

        //private bool EmployeeExists(int id)
        //{
        //    return _context.tblemployee.Any(e => e.ID == id);
        //}
    }
}