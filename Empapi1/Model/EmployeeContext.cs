using Microsoft.EntityFrameworkCore;

namespace Empapi1.Model
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)

          : base(options)

        {

            

            // To ensure that database is created through dbcontext

        }

        public DbSet<Employees1> employees1 { get; set; }
    }
}
