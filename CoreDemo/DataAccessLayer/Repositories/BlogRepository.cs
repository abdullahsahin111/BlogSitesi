using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {

        public void Delete(Blog t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }


        public Blog GetById(int id)
        {
            using var c = new Context();

            return c.Blogs.Find(id);
        }

        public List<Blog> GetListAll()
        {
            using var c = new Context();

            return c.Blogs.ToList();
        }

        public void Insert(Blog t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Blog t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
