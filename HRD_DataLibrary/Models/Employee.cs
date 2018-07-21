using System;
using System.Collections.Generic;

namespace HRD_DataLibrary.Models
{
    public class Employee
    {
        public Employee()
        {
            Departments = new HashSet<Department>();
            FiredEmployees = new HashSet<FiredEmployee>();
            Rewards = new HashSet<Reward>();
            WorkedTime = new HashSet<WorkedTime>();
        }

        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Education { get; set; }
        public DateTime EmploymentDate { get; set; }

        public Position Position { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<FiredEmployee> FiredEmployees { get; set; }
        public ICollection<Reward> Rewards { get; set; }
        public ICollection<WorkedTime> WorkedTime { get; set; }
    }
}
