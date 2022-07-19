using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Mumos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mumos.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<FeedBack> FeedBacks { get; set; }

        public DbSet<Industry> Industries { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Sector> Sectors { get; set; }

        public DbSet<Technology> Technologies { get; set; }

        public DbSet<JobUser> JobUsers { get; set; }
    }
}
