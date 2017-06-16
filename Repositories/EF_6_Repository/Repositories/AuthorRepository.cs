using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BaseEnt = RepositoryBase.Entities;
using AutoMapper;

namespace EF_6_Repository.Repositories
{
    public class AuthorRepository : Base.EF6Repository, RepositoryBase.Repositories.IAuthorRepository
    {
        public void Delete(BaseEnt.Author entity)
        {
            Model.Authors.Remove(Mapper.Map<Model.Author>(entity));
            Model.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = GetById(id);
            Delete(entity);            
        }

        public IEnumerable<BaseEnt.Author> GetAll()
        {
            var tempReturn = Model.Set<Model.Author>().ToList();
            return tempReturn.Select(b => Mapper.Map<BaseEnt.Author>(b));
        }

        public BaseEnt.Author GetById(int id)
        {
            return Mapper.Map<BaseEnt.Author>(Model.Authors.SingleOrDefault(t => t.AuthorID == id));
        }

        public void Insert(BaseEnt.Author entity)
        {
            Model.Authors.Add(Mapper.Map<Model.Author>(entity));
            Model.SaveChanges();
        }

        public void Update(BaseEnt.Author entity)
        {
            var previous = Model.Authors.FirstOrDefault(b => b.AuthorID == entity.AuthorID);
            previous = Mapper.Map<Model.Author>(entity);

            Model.SaveChanges();
        }

        public IEnumerable<BaseEnt.Author> SearchFor(Expression<Func<BaseEnt.Author, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
