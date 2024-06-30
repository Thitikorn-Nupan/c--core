using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandCShap.syntax
{
    internal class UseVariables
    {
        public void declareVars()
        {
            // types of vars
            int a = 0;
            decimal c = 0;
            double b = 0.1D, e = 0.2D, f = 0.3D; // declare multiples
            long g = 100000000;
            float h = 0.4F;
            string name = "something";
            char alphabet = 'A';
            const bool conn = true; // const it means mark this var it's a constand

        }

        public void declareArrays()
        {
            string[] employees;
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] numbers = { 10, 20, 30, 40 };
        }
    }
}
