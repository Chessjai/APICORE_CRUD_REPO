using System.ComponentModel.DataAnnotations;

namespace Empapi1.Model
{
    public class Employees1
    {
        [Key]

        public int EmpId { get; set; }

        //Unique Identifier

        public string Name { get; set; }

        //Name of the employee

        public string Dept { get; set; }

        //Name of the employee

        public string Address { get; set; }

        //Name of the employee

    
}
}
