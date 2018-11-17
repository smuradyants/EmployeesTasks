using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesTasks.Data.Seeders
{
    public class SeederUsers
    {
        public static async Task InitializeAsync(UserManager<IdentityUser> userManager)
        {
            if (await userManager.FindByNameAsync("test@test.com") == null)
            {
                var user = new IdentityUser { UserName = "test@test.com", Email = "test@test.com" };
                await userManager.CreateAsync(user, "123");
            }
        }
    }
}
