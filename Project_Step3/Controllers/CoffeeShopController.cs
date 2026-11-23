using Microsoft.AspNetCore.Mvc;
using Project_Step3.Interfaces;

namespace Project_Step3.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class CoffeeShopController : ControllerBase
    {

        private ISingletonCoffee _singletonCoffee1;
        private ISingletonCoffee _singletonCoffee2;

        private IScopedCoffee _scopedCoffee1;
        private IScopedCoffee _scopedCoffee2;

        private ITransientCoffee _transientCoffee1;
        private ITransientCoffee _transientCoffee2;

        public CoffeeShopController(ISingletonCoffee singleton1, ISingletonCoffee singleton2, IScopedCoffee scopedCoffee1, IScopedCoffee scopedCoffee2, ITransientCoffee transientCoffee1, ITransientCoffee transientCoffee2)
        {
            _singletonCoffee1 = singleton1;
            _singletonCoffee2 = singleton2;

            _scopedCoffee1 = scopedCoffee1;
            _scopedCoffee2 = scopedCoffee2;

            _transientCoffee1 = transientCoffee1;
            _transientCoffee2 = transientCoffee2;
        }

        [HttpGet("GetCoffee")]
        public IActionResult GetCoffee()
        {
            var singletonResult = new CoffeeType()
            {
                cup1 = _singletonCoffee1.GetCoffeeId(),
                cup2 = _singletonCoffee2.GetCoffeeId()
            };

            var scopedResult = new CoffeeType()
            {
                cup1 = _scopedCoffee1.GetCoffeeId(),
                cup2 = _scopedCoffee2.GetCoffeeId()
            };

            var transientResult = new CoffeeType()
            {
                cup1 = _transientCoffee1.GetCoffeeId(),
                cup2 = _transientCoffee2.GetCoffeeId()
            };
            var FinalResult = new { singletonResult, scopedResult, transientResult };
            return Ok(FinalResult);
        }



        public class CoffeeType
        {
            public string cup1 { get; set; }
            public string cup2 { get; set; }

        }
    }
}
