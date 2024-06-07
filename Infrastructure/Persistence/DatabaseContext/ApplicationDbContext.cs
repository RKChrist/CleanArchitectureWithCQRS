using Domain.Entities.Auth;
using Domain.Entities.Link;
using Domain.Entities.Photos;
using Domain.Entities.Project;
using Domain.Entities.Resources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Pipe> Pipes { get; set; }
        public DbSet<SprinklerHead> SprinklerHeads { get; set; }
        public DbSet<Valve> Valves { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Photo> Photos { get; set; }
        

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Company> Companys { get; set; }

        

        public DbSet<Group> Groups { get; set; }

        public DbSet<Project> Projects { get; set; }

        //Links
        public DbSet<LinkMaterialPhoto> LinkMaterialPhotos { get; set; }
        public DbSet<LinkGroupProject> LinkGroupProjects { get; set; }
        public DbSet<LinkUserGroup> LinkUserGroups { get; set; }

        public DbSet<LinkUserProject> LinkUserProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LinkUserProject>()
                .HasKey(o => new { o.UserId, o.ProjectId });

            modelBuilder.Entity<LinkGroupProject>()
                .HasKey(o => new { o.GroupId, o.ProjectId });

            modelBuilder.Entity<LinkUserGroup>()
                .HasKey(o => new { o.UserId, o.GroupId });

            modelBuilder.Entity<LinkMaterialPhoto>()
                .HasKey(o => new { o.MaterialId, o.PhotoId });
        }
    }
}
