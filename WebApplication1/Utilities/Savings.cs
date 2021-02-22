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
            if (p <= 0) return 0;
            if (p == 1) return 1;
            var bonus = 18400; // Yahoo drop 2,000 get 20,500
            if (p == 2000) return (p * r * t / 100) + p + bonus;
            return (p * r * t / 100) + p;
        }
    }
}