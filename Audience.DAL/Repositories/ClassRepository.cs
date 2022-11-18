using Audience.DAL.EF;
using Audience.DAL.Entities;
using Audience.DAL.Interfaces;
using Audience.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audience.DAL.Repositories
{
    public class ClassRepository : IRepository<Class>
    {
        private AudienceDbContext db;

        public ClassRepository(AudienceDbContext context)
        {
            this.db = context;
        }

        public Result Create(Class item)
        {
            if(item.DateTime < DateTime.Now)
            {
                return "Нельзя ставить в прошлом";
            }
            db.Add(item);
            return true;
        }

        public Result Delete(int id)
        {
            
        }

        public Class Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Class> GetAll()
        {
            throw new NotImplementedException();
        }

        public Result Update(Class item)
        {
            throw new NotImplementedException();
        }
    }
}
