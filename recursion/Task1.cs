using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recursion
{
    internal class Task1
    {
        private double N;
        public Task1(double n)
        {
            N = n;
        }

        public double RecursionSolution(int p)
        {
            if (p == 1)
                return N;

            var powered = RecursionSolution(p / 2);
            var squared = powered * powered;

            if (p % 2 == 0)
                return squared; 

            return squared * N;
        }

        public double IterableSolution(int p)
        {
            double result = 1;
            for (;p > 0; p/=2)
            {
                if (p % 2 != 0)
                    result *= N;
                N *= N;
            }
            return result;
        }
    }
}
