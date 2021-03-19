using Common.Data.Models.Logins;
using Common.Data.Models.User;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data
{
    public class AppDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options,IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options,operationalStoreOptions)
        {

        }
        public virtual DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
