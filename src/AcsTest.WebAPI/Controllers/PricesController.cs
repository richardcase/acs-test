using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AcsTest.WebAPI.Controllers
{
    [Route("prices")]
    public class PricesController : Controller
    {
        [HttpGet("{id}")]
        public List<SkuPrice> Get(int id)
        {
            return GetSkuPricesByProductId(id);
        }

        private List<SkuPrice> GetSkuPricesByProductId(int productId)
        {
            List<SkuPrice> skuPrices = new List<SkuPrice>
            {
                new SkuPrice
                {
                    Currentprice = 10.99,
                    EffectiveDate = DateTime.UtcNow,
                    HighestPrice = 15.00,
                    Rrp = 20.00,
                    SkuId = 12345,
                    Annotation = Environment.MachineName
                },
                new SkuPrice
                {
                    Currentprice = 6.00,
                    EffectiveDate = DateTime.UtcNow,
                    HighestPrice = 10.00,
                    Rrp = 12.00,
                    SkuId = 95959,
                    Annotation = Environment.MachineName
                }
            };

            return skuPrices;
        }
    }
}
