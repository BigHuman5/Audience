using Audience.BLL.Interfaces;
using Audience.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Audience.Controllers
{
    [Route("[controller]/[action]")]
    public class AudiencesController : Controller
    {
        IAudiencesServices services;

        public AudiencesController(IAudiencesServices services)
        {
            this.services = services;
        }

        [HttpGet]
        public async Task<ActionResult> All()
        {
            IEnumerable<Audiences> all = await services.GetAll();
            return View(all);
        }
    }
}
