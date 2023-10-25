using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Provider=SQLNCLI10;Server=94.73.170.34;Database=u1447334_dbCore; Uid=u1447334_user291;Pwd=sx23VwTx5GtKqqi;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Context> Contexts { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
