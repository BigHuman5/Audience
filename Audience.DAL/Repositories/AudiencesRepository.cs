using Audience.DAL.EF;
using Audience.DAL.Entities;
using Audience.DAL.Interfaces;
using Audience.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audience.DAL.Repositories
{
    public class AudiencesRepository : IRepository<Audiences>
    {
        private AudienceDbContext db;

        public AudiencesRepository(AudienceDbContext context)
        {
            this.db = context;
        }

        public async Task<bool> Create(Audiences item)
        {
            await db.Audiences.AddAsync(item);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var Audience = await db.Audiences.FindAsync(id);
            if (Audience != null)
            {
                db.Audiences.Remove(Audience);
                return true;
            }
            return false;
        }

        public async Task<Audiences> Get(int id)
        {
            var Audience = await db.Audiences.FindAsync(id);
            if (Audience != null)
            {
                return Audience;
            }
            return null;
        }

        public async Task<IEnumerable<Audiences>> GetAll()
        {
            return await db.Audiences.ToListAsync();
        }

        public async Task<bool> isHaveItem(string item,string mean)
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
