using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.WebUI.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {

            //ADMİN
            var Adminusername = configuration["Data:AdminUser:username"];
            var Adminemail = configuration["Data:AdminUser:email"];
            var Adminpassword = configuration["Data:AdminUser:password"];
            var Adminrole = configuration["Data:AdminUser:role"];

            if (await userManager.FindByNameAsync(Adminusername) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Adminrole));

                var user = new ApplicationUser()
                {
                    UserName = Adminusername,
                    Email = Adminemail,
                    FullName = "Admin User",
                    RoleName = "Admin",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Adminpassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Adminrole);
                }
            }

            //COMPETENT
            var Competentusername = configuration["Data:CompetentUser:username"];
            var Competentemail = configuration["Data:CompetentUser:email"];
            var Competentpassword = configuration["Data:CompetentUser:password"];
            var Competentrole = configuration["Data:CompetentUser:role"];

            if (await userManager.FindByNameAsync(Competentusername) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Competentrole));

                var user = new ApplicationUser()
                {
                    UserName = Competentusername,
                    Email = Competentemail,
                    FullName = "Competent User",
                    RoleName = "Competent",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Competentpassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Competentrole);
                }
            }

            //ATTENDANT
            var Attendantusername = configuration["Data:AttendantUser:username"];
            var Attendantemail = configuration["Data:AttendantUser:email"];
            var Attendantpassword = configuration["Data:AttendantUser:password"];
            var Attendantrole = configuration["Data:AttendantUser:role"];

            if (await userManager.FindByNameAsync(Attendantusername) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Attendantrole));

                var user = new ApplicationUser()
                {
                    UserName = Attendantusername,
                    Email = Attendantemail,
                    FullName = "Attendant User",
                    RoleName = "Attendant",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Attendantpassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Attendantrole);
                }
            }

            //ATTENDANT1
            var Attendantuser1name = configuration["Data:AttendantUser1:username"];
            var Attendant1email = configuration["Data:AttendantUser1:email"];
            var Attendant1password = configuration["Data:AttendantUser1:password"];
            var Attendant1role = configuration["Data:AttendantUser1:role"];

            if (await userManager.FindByNameAsync(Attendantuser1name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Attendant1role));

                var user = new ApplicationUser()
                {
                    UserName = Attendantuser1name,
                    Email = Attendant1email,
                    FullName = "Attendant User 1",
                    RoleName = "Attendant",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Attendant1password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Attendant1role);
                }
            }

            //ATTENDANT2
            var Attendantuser2name = configuration["Data:AttendantUser2:username"];
            var Attendant2email = configuration["Data:AttendantUser2:email"];
            var Attendant2password = configuration["Data:AttendantUser2:password"];
            var Attendant2role = configuration["Data:AttendantUser2:role"];

            if (await userManager.FindByNameAsync(Attendantuser2name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Attendant2role));

                var user = new ApplicationUser()
                {
                    UserName = Attendantuser2name,
                    Email = Attendant2email,
                    FullName = "Attendant User 2",
                    RoleName = "Attendant",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Attendant2password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Attendant2role);
                }
            }

            //ATTENDANT3
            var Attendantuser3name = configuration["Data:AttendantUser3:username"];
            var Attendant3email = configuration["Data:AttendantUser3:email"];
            var Attendant3password = configuration["Data:AttendantUser3:password"];
            var Attendant3role = configuration["Data:AttendantUser3:role"];

            if (await userManager.FindByNameAsync(Attendantuser3name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Attendant3role));

                var user = new ApplicationUser()
                {
                    UserName = Attendantuser3name,
                    Email = Attendant3email,
                    FullName = "Attendant User 3",
                    RoleName = "Attendant",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Attendant3password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Attendant3role);
                }
            }

            //ATTENDANT4
            var Attendantuser4name = configuration["Data:AttendantUser4:username"];
            var Attendant4email = configuration["Data:AttendantUser4:email"];
            var Attendant4password = configuration["Data:AttendantUser4:password"];
            var Attendant4role = configuration["Data:AttendantUser4:role"];

            if (await userManager.FindByNameAsync(Attendantuser4name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Attendant4role));

                var user = new ApplicationUser()
                {
                    UserName = Attendantuser4name,
                    Email = Attendant4email,
                    FullName = "Attendant User 4",
                    RoleName = "Attendant",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Attendant4password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Attendant4role);
                }
            }

            //STAFF
            var Staffusername = configuration["Data:StaffUser:username"];
            var Staffemail = configuration["Data:StaffUser:email"];
            var Staffpassword = configuration["Data:StaffUser:password"];
            var Staffrole = configuration["Data:StaffUser:role"];

            if (await userManager.FindByNameAsync(Staffusername) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Staffrole));

                var user = new ApplicationUser()
                {
                    UserName = Staffusername,
                    Email = Staffemail,
                    FullName = "Staff User",
                    RoleName = "Staff",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Staffpassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Staffrole);
                }
            }

            //SATFF1
            var Staffuser1name = configuration["Data:StaffUser1:username"];
            var Staff1email = configuration["Data:StaffUser1:email"];
            var Staff1password = configuration["Data:StaffUser1:password"];
            var Staff1role = configuration["Data:StaffUser1:role"];

            if (await userManager.FindByNameAsync(Staffuser1name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Staff1role));

                var user = new ApplicationUser()
                {
                    UserName = Staffuser1name,
                    Email = Staff1email,
                    FullName = "Staff User 1",
                    RoleName = "Staff",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Staff1password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Staff1role);
                }
            }

            //STAFF2
            var Staffuser2name = configuration["Data:StaffUser2:username"];
            var Staff2email = configuration["Data:StaffUser2:email"];
            var Staff2password = configuration["Data:StaffUser2:password"];
            var Staff2role = configuration["Data:StaffUser2:role"];

            if (await userManager.FindByNameAsync(Staffuser2name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Staff2role));

                var user = new ApplicationUser()
                {
                    UserName = Staffuser2name,
                    Email = Staff2email,
                    FullName = "Staff User 2",
                    RoleName = "Staff",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Staff2password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Staff2role);
                }
            }

            //STAFF3
            var Staffuser3name = configuration["Data:StaffUser3:username"];
            var Staff3email = configuration["Data:StaffUser3:email"];
            var Staff3password = configuration["Data:StaffUser1:password"];
            var Staff3role = configuration["Data:StaffUser3:role"];

            if (await userManager.FindByNameAsync(Staffuser3name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Staff3role));

                var user = new ApplicationUser()
                {
                    UserName = Staffuser3name,
                    Email = Staff3email,
                    FullName = "Staff User 3",
                    RoleName = "Staff",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Staff3password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Staff3role);
                }
            }

            //STAFF4
            var Staffuser4name = configuration["Data:StaffUser4:username"];
            var Staff4email = configuration["Data:StaffUser4:email"];
            var Staff4password = configuration["Data:StaffUser4:password"];
            var Staff4role = configuration["Data:StaffUser4:role"];

            if (await userManager.FindByNameAsync(Staffuser4name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Staff4role));

                var user = new ApplicationUser()
                {
                    UserName = Staffuser4name,
                    Email = Staff4email,
                    FullName = "Staff User 4",
                    RoleName = "Staff",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Staff4password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Staff4role);
                }
            }

            //STAFF5
            var Staffuser5name = configuration["Data:StaffUser5:username"];
            var Staff5email = configuration["Data:StaffUser5:email"];
            var Staff5password = configuration["Data:StaffUser5:password"];
            var Staff5role = configuration["Data:StaffUser5:role"];

            if (await userManager.FindByNameAsync(Staffuser5name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Staff5role));

                var user = new ApplicationUser()
                {
                    UserName = Staffuser5name,
                    Email = Staff5email,
                    FullName = "Staff User 5",
                    RoleName = "Staff",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Staff5password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Staff5role);
                }
            }

            //STAFF6
            var Staffuser6name = configuration["Data:StaffUser6:username"];
            var Staff6email = configuration["Data:StaffUser6:email"];
            var Staff6password = configuration["Data:StaffUser6:password"];
            var Staff6role = configuration["Data:StaffUser6:role"];

            if (await userManager.FindByNameAsync(Staffuser6name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Staff6role));

                var user = new ApplicationUser()
                {
                    UserName = Staffuser6name,
                    Email = Staff6email,
                    FullName = "Staff User 6",
                    RoleName = "Staff",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Staff6password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Staff6role);
                }
            }

            //STAFF7
            var Staffuser7name = configuration["Data:StaffUser7:username"];
            var Staff7email = configuration["Data:StaffUser7:email"];
            var Staff7password = configuration["Data:StaffUser7:password"];
            var Staff7role = configuration["Data:StaffUser7:role"];

            if (await userManager.FindByNameAsync(Staffuser7name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Staff7role));

                var user = new ApplicationUser()
                {
                    UserName = Staffuser7name,
                    Email = Staff7email,
                    FullName = "Staff User 7",
                    RoleName = "Staff",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Staff7password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Staff7role);
                }
            }

            //STAFF8
            var Staffuser8name = configuration["Data:StaffUser8:username"];
            var Staff8email = configuration["Data:StaffUser8:email"];
            var Staff8password = configuration["Data:StaffUser8:password"];
            var Staff8role = configuration["Data:StaffUser8:role"];

            if (await userManager.FindByNameAsync(Staffuser8name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Staff8role));

                var user = new ApplicationUser()
                {
                    UserName = Staffuser8name,
                    Email = Staff8email,
                    FullName = "Staff User 8",
                    RoleName = "Staff",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Staff8password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Staff8role);
                }
            }

            //STAFF9
            var Staffuser9name = configuration["Data:StaffUser9:username"];
            var Staff9email = configuration["Data:StaffUser9:email"];
            var Staff9password = configuration["Data:StaffUser9:password"];
            var Staff9role = configuration["Data:StaffUser9:role"];

            if (await userManager.FindByNameAsync(Staffuser9name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Staff9role));

                var user = new ApplicationUser()
                {
                    UserName = Staffuser9name,
                    Email = Staff9email,
                    FullName = "Staff User 9",
                    RoleName = "Staff",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Staff9password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Staff9role);
                }
            }

            //STAFF10
            var Staffuser10name = configuration["Data:StaffUser10:username"];
            var Staff10email = configuration["Data:StaffUser10:email"];
            var Staff10password = configuration["Data:StaffUser10:password"];
            var Staff10role = configuration["Data:StaffUser10:role"];

            if (await userManager.FindByNameAsync(Staffuser10name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Staff10role));

                var user = new ApplicationUser()
                {
                    UserName = Staffuser10name,
                    Email = Staff10email,
                    FullName = "Staff User 10",
                    RoleName = "Staff",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Staff10password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Staff10role);
                }
            }

            //CUSTOMER
            var Customerusername = configuration["Data:CustomerUser:username"];
            var Customeremail = configuration["Data:CustomerUser:email"];
            var Customerpassword = configuration["Data:CustomerUser:password"];
            var Customerrole = configuration["Data:CustomerUser:role"];

            if (await userManager.FindByNameAsync(Customerusername) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Customerrole));

                var user = new ApplicationUser()
                {
                    UserName = Customerusername,
                    Email = Customeremail,
                    FullName = "Customer User",
                    RoleName = "Customer",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Customerpassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Customerrole);
                }
            }

            //CUSTOMER1
            var Customeruser1name = configuration["Data:CustomerUser1:username"];
            var Customer1email = configuration["Data:CustomerUser1:email"];
            var Customer1password = configuration["Data:CustomerUser1:password"];
            var Customer1role = configuration["Data:CustomerUser1:role"];

            if (await userManager.FindByNameAsync(Customeruser1name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Customer1role));

                var user = new ApplicationUser()
                {
                    UserName = Customeruser1name,
                    Email = Customer1email,
                    FullName = "Customer User1",
                    RoleName = "Customer",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Customer1password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Customer1role);
                }
            }

            //CUSTOMER2
            var Customeruser2name = configuration["Data:CustomerUser2:username"];
            var Customer2email = configuration["Data:CustomerUser2:email"];
            var Customer2password = configuration["Data:CustomerUser2:password"];
            var Customer2role = configuration["Data:CustomerUser2:role"];

            if (await userManager.FindByNameAsync(Customeruser2name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Customer2role));

                var user = new ApplicationUser()
                {
                    UserName = Customeruser2name,
                    Email = Customer2email,
                    FullName = "Customer User 2",
                    RoleName = "Customer",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Customer2password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Customer2role);
                }
            }

            //CUSTOMER3
            var Customeruser3name = configuration["Data:CustomerUser3:username"];
            var Customer3email = configuration["Data:CustomerUser3:email"];
            var Customer3password = configuration["Data:CustomerUser3:password"];
            var Customer3role = configuration["Data:CustomerUser3:role"];

            if (await userManager.FindByNameAsync(Customeruser3name) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(Customer3role));

                var user = new ApplicationUser()
                {
                    UserName = Customeruser3name,
                    Email = Customer3email,
                    FullName = "Customer User",
                    RoleName = "Customer",
                    Deleted = false,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, Customer3password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Customer3role);
                }
            }

        }
    }
}
