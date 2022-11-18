using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audience.DAL.Entities
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string NameGroup { get; set; }

        [Required]
        public Audiences Audiences { get; set; }

        public int AudiencesId { get; set; }
        [Required]
        public Lecturer Lecturer { get; set; }
        public int LecturerId { get; set; }
        public bool isNeedMedia { get; set; } = false;

    }
}
