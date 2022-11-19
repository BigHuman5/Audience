using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audience.BLL.DTO
{
    public class LecturerDTO
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
    }
}
