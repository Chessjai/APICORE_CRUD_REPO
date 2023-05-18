using Empapi1.Model;

namespace Empapi1.Repository
{
    public interface IEmpRepository
    {
       //this will retrieve all Employee entries

        Task<IEnumerable<Employees1>> Get();

        //This will retrieve a particular Employee entry.

        Task<Employees1> Get(int EmpId);

        //This will create an Employee entry

        Task<Employees1> Create(Employees1 employee);

        //This will update an Employee entry

        Task Update(Employees1 employee);

        //This will delete an Employee entry

        Task Delete(int EmpId);

    }
}

