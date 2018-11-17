using System;
using System.Threading.Tasks;
using EmployeesTasks.Data;
using EmployeesTasks.Data.Seeders;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeesTasks.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            RunServices(host).ConfigureAwait(true);
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        private static async Task RunServices(IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<EmployeesTasksDbContext>();
                var userManager = services.GetRequiredService<UserManager<IdentityUser>>();

                await SeedStates.InitializeAsync(context);
                await SeedPriorityLevels.InitializeAsync(context);
                await SeedEmployees.InitializeAsync(context);
                await SeedEmployeeTasks.InitializeAsync(context);
                await SeederUsers.InitializeAsync(userManager);

                //SeedCompanies.Initialize(context);
                //SeedContacts.Initialize(context);
                //SeedNotifications.Initialize(context);
                //SeedAnnouncements.Initialize(context);
                //SeedEvents.Initialize(context);
                //SeedMembershipApplications.Initialize(context);
                //SeedInvestmentPages.Initialize(context);
                //await SeedInvestments.InitializeAsync(context, userManager);
            }
        }
    }
}
