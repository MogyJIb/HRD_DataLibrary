using System.Collections.Generic;

namespace HRD_DataLibrary.Models
{
    public class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
            Vacancies = new HashSet<Vacancy>();
        }

        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Duties { get; set; }
        public string Requirements { get; set; }

        public Department Department { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
    }
}
