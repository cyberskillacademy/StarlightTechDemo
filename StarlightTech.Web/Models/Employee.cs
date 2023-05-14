using System.ComponentModel.DataAnnotations;

namespace StarlightTech.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        //navigation property
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
