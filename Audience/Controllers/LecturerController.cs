using Audience.BLL.DTO;
using Audience.BLL.Interfaces;
using Audience.BLL.Services;
using Audience.DAL.Entities;
using Audience.Models.Class;
using Audience.Models.Lecturer;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Audience.Controllers
{
    public class LecturerController : ApiController
    {
        ILecturerServices services;

        public LecturerController(ILecturerServices services)
        {
            this.services = services;
        }

        [HttpGet]
        public async Task<ActionResult> All()
        {
            /*IEnumerable<LecturerDTO> lecturerDTO = await services.GetAll();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<LecturerDTO, LecturerResponseModel>()).CreateMapper();
            var lecturerResponseModels = mapper.Map<IEnumerable<LecturerDTO>, List<LecturerResponseModel>>(lecturerDTO);

            //IEnumerable<Lecturer> all = await services.GetAll();
            return Ok(lecturerResponseModels);*/
            return Ok(await new LecturerResponseModelBuilder(this.services).Build());
        }
    }
}
