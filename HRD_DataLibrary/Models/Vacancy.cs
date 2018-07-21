namespace HRD_DataLibrary.Models
{
    public class Vacancy
    {
        public int VacancyId { get; set; }
        public int PositionId { get; set; }
        public int Number { get; set; }

        public Position Position { get; set; }
    }
}
