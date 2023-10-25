using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Provider=SQLNCLI10;Server=94.73.170.34;Database=u1447334_dbCore; Uid=u1447334_user291;Pwd=sx23VwTx5GtKqqi;");
        }
    }
}
