using Microsoft.EntityFrameworkCore;
using SqlConnectionFirst.Models;

namespace SqlConnectionFirst.DAL
{
    public class DataBase:DbContext
    {
        public DataBase(DbContextOptions<DataBase> options):base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
