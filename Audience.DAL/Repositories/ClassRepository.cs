using Audience.DAL.EF;
using Audience.DAL.Entities;
using Audience.DAL.Interfaces;
using Audience.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

        public async Task<bool> Create(Class item)
        {
            await db.Class.AddAsync(item);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var Class = await db.Class.FindAsync(id);
            if (Class != null)
            {
                db.Class.Remove(Class);
                return true;
            }
            return false;
        }

        public async Task<Class> Get(int id)
        {
            var Class = await db.Class.FindAsync(id);
            if (Class != null)
            {
                return Class;
            }
            return null;
        }

        public async Task<IEnumerable<Class>> GetAll()
        {
            return await db.Class.AsNoTracking().ToListAsync();
        }

        public async Task<bool> isHaveItem(string item, string mean)
        {
            var Item = await db.Audiences
                .Where(a => item == mean)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            if (Item != null)
            {
                return true;
            }
            return false;
        }
    }
}
