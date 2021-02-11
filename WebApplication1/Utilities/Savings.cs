using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Utilities
{
    public class Savings
    {
        public decimal InterestCalculator(decimal p, decimal r, decimal t)
        {
            return (p * r * t / 100) + p;
        }
    }
}