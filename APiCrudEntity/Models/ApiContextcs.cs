using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace APiCrudEntity.Models
{
    public class ApiContext:DbContext
    {
        public ApiContext(DbContextOptions options) : base(options)
        {
            
        }

        //here students is the table name in database
        public DbSet<Student> Students { get; set; }


    }
}
