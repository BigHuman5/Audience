using Audience.BLL.DTO;
using Audience.BLL.Interfaces;
using Audience.DAL.Entities;
using Audience.Models.Audiences;
using Audience.Models.Lecturer;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Audience.Controllers
{
    public class AudiencesController : ApiController
    {
        IAudiencesServices services;

        public AudiencesController(IAudiencesServices services)
        {
            this.services = services;
        }

        [HttpGet]
        public async Task<ActionResult> All()
        {
            IEnumerable<AudiencesDTO> audiencesDTO = await services.GetAll();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<AudiencesDTO, AudiencesResponseModel>()).CreateMapper();
            var audiencesResponseModels = mapper.Map<IEnumerable<AudiencesDTO>, List<AudiencesResponseModel>>(audiencesDTO);

            return Ok(audiencesResponseModels);
        }
    }
}
