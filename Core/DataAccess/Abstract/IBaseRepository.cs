using Core.Entities;

namespace Core.DataAccess.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
