using Microsoft.EntityFrameworkCore;

namespace AjaxProject.DAL
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI;initial Catalog=AjaxDb;integrated Security=true");
        }
        public  DbSet<Product> Products { get; set; }
    }
}
