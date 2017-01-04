using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcsTest.WebAPI
{
    public class SkuPrice
    {
        public double Currentprice { get; set; }

        public DateTime EffectiveDate { get; set; }

        public double HighestPrice { get; set; }

        public double Rrp { get; set; }

        public int SkuId { get; set; }

        public string Annotation { get; set; }
    }
}
