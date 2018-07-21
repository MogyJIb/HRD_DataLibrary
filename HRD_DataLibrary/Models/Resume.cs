using System;

namespace HRD_DataLibrary.Models
{
    public class Resume
    {
        public int ResumeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public string Institution { get; set; }
        public string Specialty { get; set; }
    }
}
