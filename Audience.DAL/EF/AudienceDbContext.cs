using Audience.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Audience.DAL.EF;

public class AudienceDbContext : IdentityDbContext<IdentityUser>
{
    public DbSet<Class> Class { get; set; }
    public DbSet<Audiences> Audiences { get; set; }
    public DbSet<Lecturer> Lecturers { get; set; }
    public AudienceDbContext(DbContextOptions<AudienceDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
