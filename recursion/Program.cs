using System;

namespace recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            T1();
        }


        static void T1()
        {
            var t1 = new Task1(57);
            Console.WriteLine(t1.RecursionSolution(7));
            Console.WriteLine(t1.IterableSolution(7));
        }

        static void T2()
        {
            var t2 = new Task2();
            Console.WriteLine(t2.RecursionSolution(40));
            Console.WriteLine(t2.IterableSolution(40));
        }
    }
}
