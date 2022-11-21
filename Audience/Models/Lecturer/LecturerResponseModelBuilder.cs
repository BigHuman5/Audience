using Audience.BLL.DTO;
using Audience.BLL.Interfaces;
using Audience.Models.Class;
using AutoMapper;

namespace Audience.Models.Lecturer
{
    public class LecturerResponseModelBuilder
    {
        ILecturerServices services;

        public LecturerResponseModelBuilder(ILecturerServices services)
        {
            this.services = services;
        }
        public async Task<List<LecturerResponseModel>> Build()
        {
            IEnumerable<LecturerDTO> lecturerDTO = await services.GetAll();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<LecturerDTO, LecturerResponseModel>()).CreateMapper();
            var lecturerResponseModels = mapper.Map<IEnumerable<LecturerDTO>, List<LecturerResponseModel>>(lecturerDTO);
            return lecturerResponseModels;
        }
    }
}
