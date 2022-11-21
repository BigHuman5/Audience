using Audience.BLL.DTO;
using Audience.BLL.Interfaces;
using Audience.Models.Audiences;
using Audience.Models.Lecturer;
using Audience.Models.TimetableOfClasses;

namespace Audience.Models.Class
{
    public class ClassResponseModelBuilder
    {
        IClassServices services;

        public ClassResponseModelBuilder(IClassServices services)
        {
            this.services = services;
        }
        public async Task<List<ClassResponseModel>> Build()
        {
            List<ClassDTO> all = await services.GetAll();
            List<ClassResponseModel> CRM = new List<ClassResponseModel>();
            foreach (var item in all)
            {
                ClassResponseModel classResponse = new ClassResponseModel
                {
                    Date = item.Date,
                    timetableOfClasses = new TimetableOfClassesResponseModel
                    {
                        TimeStart = item.timetableOfClasses.TimeStart,
                        TimeEnd = item.timetableOfClasses.TimeEnd,
                    },
                    isNeedMedia = item.isNeedMedia,
                    NameGroup = item.NameGroup,
                    Audiences = new AudiencesResponseModel
                    {
                        Number = item.Audiences.Number,
                        IsHaveMedia = item.Audiences.IsHaveMedia
                    },
                    Lecturer = new LecturerResponseModel
                    {
                        SurName = item.Lecturer.SurName,
                        Name = item.Lecturer.Name,
                        Patronymic = item.Lecturer.Patronymic
                    },

                };
                CRM.Add(classResponse);
            }
            return CRM;
        }
    }
}
