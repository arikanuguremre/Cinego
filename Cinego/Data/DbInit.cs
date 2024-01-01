using Cinego.Data.Enums;
using Cinego.Data.Static;
using Cinego.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Policy;

namespace Cinego.Data
{
	public class DbInit
	{
       
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				//roles
				var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
		
				if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
					await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<User>>();
				var adminUser = await userManager.FindByEmailAsync("admin@cinego.com");
				if(adminUser == null) {
                    
                    var newAdmin = new User()
					{
						FullName = "Admin User",
						UserName = "admin",
						Email = "admin@cinego.com",
						EmailConfirmed = true
					};
                 
                       var res= await userManager.CreateAsync(newAdmin, "Admin123.");
                  
                       await userManager.AddToRoleAsync(newAdmin, UserRoles.Admin);
                    
                   
				
				}
                var appUser = await userManager.FindByEmailAsync("user@cinego.com");
                if (appUser == null)
                {
                    var newSimpleUser = new User()
                    {
                        FullName = "Simple User",
                        UserName = "user",
                        Email = "user@cinego.com",
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newSimpleUser, "User123.");
                    await userManager.AddToRoleAsync(newSimpleUser, UserRoles.User);
                }

            }
        }
	}
}
