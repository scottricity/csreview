using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Systems of Equation, but C#!";

            double c1X = 2;
            double c1Y = 3;
            double c1Price = 25.65;

            double c2X = 5;
            double c2Y = 2;
            double c2Price = 30.00;

            double c3X = 7;
            double c3Y = 2;
            double c3Price;

            double c1SolutionX = -c1X/c1Y;
            double c1SolutionPrice = -c1Price/c1Y;

            double c2SolutionX = -c2X/c2Y;
            double c2SolutionPrice = -c2Price/c2Y;

            double c1XCarriedOver = Math.Sign(c1SolutionX);
            double c1PriceCarried = Math.Sign(c1SolutionPrice);
            double c2XCarriedOver = Math.Sign(c2SolutionX);
            double c2PriceCarried = Math.Sign(c2SolutionPrice);
            
            if (c2XCarriedOver == -1){
                c1SolutionX = c1SolutionX - (c2SolutionX);
                Console.WriteLine(c1SolutionX);
            }
            Console.ReadKey();
        }
    }
}