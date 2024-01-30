using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS03;Database=CoreBlogDB; Uid=sa;Pwd=93f3c00c-adeb-4111-84d3-435711d4cfe4;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }

    }



    //public class Context : DbContext
    //{
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer("Provider=SQLNCLI10;Server=94.73.170.34;Database=u1447334_dbCore; Uid=u1447334_user291;Pwd=sx23VwTx5GtKqqi;");
    //    }
    //}
}
