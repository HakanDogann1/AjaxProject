using Microsoft.EntityFrameworkCore;

namespace AjaxProject.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NOMRM5V\\SQLEXPRESS;initial catalog=AjaxDb;integrated security=true;");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}


