using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCoster
{
    class TaxBrackets
    {
        public char Id { get; set; }
        public float MinCO2 { get; set; }
        public float MaxCO2 { get; set; }
        public float TaxCost { get; set; }
        public float TaxCostAlternate { get; set; }
    }
}
