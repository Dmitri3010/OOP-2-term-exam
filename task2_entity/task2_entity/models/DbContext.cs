using System.Data.Entity;

namespace task2_entity.models
{
    public class Db_Context: DbContext
    {

        public Db_Context() : base("DefaultConnection")
        {

        }

        public DbSet<Student> dbSet { get; set; }
    }
}
