using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using VetAdmin.Infrastructure.Data;

namespace VetAdmin.Api.Controllers
{
    public class Test
    {
        ApplicationDbContext context;
        public Test(ApplicationDbContext applicationDbContext) { this.context = applicationDbContext; }
        public void CheckConnection()
        {
            try
            {
                context.Database.EnsureCreated();
            }
            catch (SqlException)
            {
                Console.Write(false.ToString());
            }
            Console.Write(true.ToString());
        }
    }
}
