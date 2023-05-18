using Empapi1.Model;
using Microsoft.EntityFrameworkCore;

namespace Empapi1.Repository
{
    public class EmployeeRepository:IEmpRepository
    {
        public readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext context)

        {

            _context = context;

        }

        public async Task<Employees1> Create(Employees1 employee)

        {

            //we are using Add method of dbset to insert entry

            _context.employees1.Add(employee);

            await _context.SaveChangesAsync();

            return employee;

        }

        public async Task Delete(int EmpId)

        {

            //we are using findasync method of dbset to find entry

            var employeeToDelete = await _context.employees1.FindAsync(EmpId);

            //we are using Remove method of dbset to delete entry

            _context.employees1.Remove(employeeToDelete);

            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Employees1>> Get()

        {

            //we are using ToListAsync method of dbset to show all entry

            return await _context.employees1.ToListAsync();

        }

        public async Task<Employees1> Get(int EmpId)

        {

            //we are using findasync method of dbset to find specific entry

            return await _context.employees1.FindAsync(EmpId);

        }

        public async Task Update(Employees1 employee)

        {

            _context.Entry(employee).State = EntityState.Modified;

            await _context.SaveChangesAsync();

        }

    }
}

