using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BaseEnt=RepositoryBase.Entities;
using AutoMapper;

namespace EF_6_Repository.Repositories
{
    public class BookRepository : Base.EF6Repository, RepositoryBase.Repositories.IBookRepository
    {
        public void Delete(BaseEnt.Book entity)
        {
            Model.Books.Remove(Mapper.Map<Model.Book>(entity));
            Model.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = GetById(id);
            Delete(entity);
        }

        public IEnumerable<BaseEnt.Book> GetAll()
        {
            return Model.Set<Model.Book>().Select(b => Mapper.Map<BaseEnt.Book>(b));
        }

        public BaseEnt.Book GetById(int id)
        {
            return Mapper.Map<BaseEnt.Book>(Model.Books.SingleOrDefault(t => t.BookID == id));
        }

        public void Insert(BaseEnt.Book entity)
        {
            Model.Books.Add(Mapper.Map<Model.Book>(entity));
            Model.SaveChanges();
        }

        public void Update(BaseEnt.Book entity)
        {
            var previous = Model.Books.FirstOrDefault(b => b.BookID == entity.BookID);
            previous = Mapper.Map<Model.Book>(entity);
            
            Model.SaveChanges();
        }

        public IEnumerable<BaseEnt.Book> SearchFor(Expression<Func<BaseEnt.Book, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
