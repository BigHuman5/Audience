namespace Audience.Models
{
    public class ClassVM
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string NameGroup { get; set; }
        public int AudiencesId { get; set; }
        public int LecturerId { get; set; }
        public bool isNeedMedia { get; set; }
    }
}
