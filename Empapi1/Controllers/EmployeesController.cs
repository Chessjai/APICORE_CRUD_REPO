using Empapi1.Model;
using Empapi1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Empapi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public readonly IEmpRepository _empRepository;

        public EmployeesController(IEmpRepository empRepository)

        {

            _empRepository = empRepository;

        }

        //HttpGet signifies that this method will handle all Get 

        //Http Request

        [HttpGet]

        public async Task<IEnumerable<Employees1>> GetEmployees()

        {

            return await _empRepository.Get();

        }

        [HttpGet("{EmpId}")]

        public async Task<ActionResult<Employees1>> GetEmployees(int EmpId)

        {

            return await _empRepository.Get(EmpId);

        }

        //HttpPost signifies that this method will handle all Post 

        //Http Request

        [HttpPost]

        public async Task<ActionResult<Employees1>> PostEmployees([FromBody] Employees1 employee)

        {

            var newEmployee = await _empRepository.Create(employee);

            return CreatedAtAction(nameof(GetEmployees), new { EmpId = newEmployee.EmpId }, newEmployee);

        }

        //HttpPut signifies that this method will handle all Put 

        //Http Request

        [HttpPut]

        public async Task<ActionResult> PutEmployees(int EmpId, [FromBody] Employees1 employee)

        {

            //Check if the given id is present database or not

            // if not then we will return bad request

            if (EmpId != employee.EmpId)

            {

                return BadRequest();

            }

            await _empRepository.Update(employee);

            return NoContent();

        }

        //HttpDelete signifies that this method will handle all 

        //Http Delete Request

        [HttpDelete("{EmpId}")]

        public async Task<ActionResult> Delete(int EmpId)

        {

            var employeeToDelete = await _empRepository.Get(EmpId);

            // first we will check i the given id is 

            //present in database or not

            if (employeeToDelete == null)

                return NotFound();

            await _empRepository.Delete(employeeToDelete.EmpId);

            return NoContent();

        }

    }
}

