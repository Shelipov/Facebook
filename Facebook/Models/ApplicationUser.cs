using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Facebook.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public ApplicationUser(string name)
        //{
        //    Id = Guid.NewGuid().ToString();
        //    UserName = name;
        //}
        ////public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        ////{
        ////    var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
        ////    return userIdentity;
        ////}
        //public string Id { get; set; }
        //public string UserName { get; set; }
        //public string Email { get; set; }
        //public string Sity { get; set; }
    }
}
