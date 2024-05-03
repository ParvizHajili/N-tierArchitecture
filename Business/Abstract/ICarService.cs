using Entities.Concrete.TableModels;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car entity);
        void Update(Car entity);
        void Delete(Car entity);
        Car GetById(int id);
        List<Car> GetAll();
    }
}
