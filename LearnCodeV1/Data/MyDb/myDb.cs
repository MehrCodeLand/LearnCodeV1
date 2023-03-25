using LearnCodeV1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnCodeV1.Data.MyDb
{
    public class myDb : DbContext
    {
        public myDb(DbContextOptions<myDb> options ) : base(options)  
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
