using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkypeApp.Infrastructure.Models;
using File = SkypeApp.Infrastructure.Models.File;

namespace SkypeApp.Infrastructure
{
    /*
     * Add migrations using the following command inside the 'Ordering.Infrastructure' project directory:
     * dotnet ef migrations add --startup-project ..\TikiShop.Api\TikiShop.Api.csproj --context TikiShopDbContext [Name]
     * dotnet ef database update --startup-project ..\TikiShop.Api\TikiShop.Api.csproj
     */
    public class SkypeAppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<File> Files { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }

        public SkypeAppDbContext(DbContextOptions<SkypeAppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
