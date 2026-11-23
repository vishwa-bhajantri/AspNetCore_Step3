using Project_Step3.Interfaces;

namespace Project_Step3.Services
{
    public class CoffeeShopService : ISingletonCoffee, IScopedCoffee, ITransientCoffee
    {
        private readonly string _coffeId;

        public CoffeeShopService()
        {
            _coffeId = Guid.NewGuid().ToString();
        }

        public string GetCoffeeId()
        {
            return _coffeId;
        }
    }
}
