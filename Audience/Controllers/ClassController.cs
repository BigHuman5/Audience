using Audience.BLL.DTO;
using Audience.BLL.Interfaces;
using Audience.Models.Audiences;
using Audience.Models.Class;
using Audience.Models.Lecturer;
using Audience.Models.TimetableOfClasses;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Audience.Controllers
{
    public class ClassController : ApiController
    {
        IClassServices services;

        public ClassController(IClassServices services)
        {
            this.services = services;
        }

        [HttpGet]
        public async Task<ActionResult> All()
        {
            //var Class = await new ClassResponseModelBuilder.Build();
            return Ok(await new ClassResponseModelBuilder(this.services).Build());
        }
    }
}
