using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.SqlServerDbContext;
using Entities.Concrete.TableModels;

namespace DataAccess.Concrete
{
    public class CarRepository : BaseRepository<Car, ApplicationDbContext>, ICarRepository
    {
        public List<Car> GetTopFiveCars()
        {
            throw new NotImplementedException();
        }
    }
}
