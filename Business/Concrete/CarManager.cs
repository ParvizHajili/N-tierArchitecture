using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete.TableModels;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarManager()
        {
            _carRepository = new CarRepository();
        }
        public void Add(Car entity)
        {
            _carRepository.Add(entity);
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
