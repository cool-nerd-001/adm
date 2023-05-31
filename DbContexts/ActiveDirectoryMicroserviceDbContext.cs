using ActiveDirectoryMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace ActiveDirectoryMicroservice.DbContexts
{

        public class ActiveDirectoryMicroserviceDbContext : DbContext
        {
            public ActiveDirectoryMicroserviceDbContext(DbContextOptions<ActiveDirectoryMicroserviceDbContext> options) : base(options)
            {


            }


            public DbSet<User> Users { get; set; }

            public DbSet<Admin> Admins { get; set; }
        }

}
