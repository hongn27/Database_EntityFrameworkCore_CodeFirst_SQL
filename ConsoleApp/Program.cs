using ConsoleApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Hongs-projects\Database_EntityFrameworkCore_CodeFirst_SQL\ConsoleApp\Data\Database.mdf;Integrated Security=True;Connect Timeout=30"));

}).Build();
    
    