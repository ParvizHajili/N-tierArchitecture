using Core.Entities;

namespace Entities.Concrete.TableModels
{
    public class Car : BaseEntity
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}
