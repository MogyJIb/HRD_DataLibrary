using System.Collections.Generic;

namespace HRD_DataLibrary.Models
{
    public class Department
    {
        public Department()
        {
            Positions = new HashSet<Position>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Cabinet { get; set; }
        public string Phone { get; set; }
        
        public ICollection<Position> Positions { get; set; }
    }
}
