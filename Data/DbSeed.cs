using Microsoft.AspNetCore.Identity;
using System.Threading;
using WebCandleShopNet7.Const;

namespace WebCandleShopNet7.Data
{
    public class DbSeed
    {
        public static async Task SeedDefaultData(IServiceProvider service)
        {
            var userMngr = service.GetService<UserManager<IdentityUser>>();
            var roleMngr = service.GetService<RoleManager<IdentityRole>>();
            await roleMngr.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleMngr.CreateAsync(new IdentityRole(Roles.User.ToString()));

            var admin = new IdentityUser
            {
                UserName = "AdminCandle1993@gmail.com",
                Email = "AdminCandle1993@gmail.com",
                EmailConfirmed = true,

            };


             var IsUserInData = await userMngr.FindByEmailAsync(admin.Email);
            if (IsUserInData is null) 
            {
                await userMngr.CreateAsync(admin, "AdminCandle1993@gmail.com");
                await userMngr.AddToRoleAsync(admin,Roles.Admin.ToString());
            }
        }
    }
}
