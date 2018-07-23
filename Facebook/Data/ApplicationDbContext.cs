using System;
using System.Collections.Generic;
using System.Text;
using Facebook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Facebook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<FacebookOptions> Facebookoptions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
