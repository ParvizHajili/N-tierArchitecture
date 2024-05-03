using Core.DataAccess.Abstract;
using Entities.Concrete.TableModels;

namespace DataAccess.Abstract
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        List<Car> GetTopFiveCars();
    }
}
