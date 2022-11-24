
using Audience.DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace Audience.BLL.DTO
{
    public class ClassDTO
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public TimetableOfClassesDTO timetableOfClasses { get; set; }

        //public int timetableOfClassesId { get; set; }
        //public TimeSpan timetableOfClassesTimeStart { get; set; }
        //public TimeSpan timetableOfClassesTimeEnd { get; set; }
        public string NameGroup { get; set; }
        public AudiencesDTO Audiences { get; set; }
        public LecturerDTO Lecturer { get; set; }
        public bool isNeedMedia { get; set; }
    }


}
