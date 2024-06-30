using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandCShap.services
{
    public class MyMath
    {   
        // we call overloading methods same name different args type
        public float multiple(int x, int y)
        {
            Console.WriteLine("x is "+x+"\ny is "+y);
            return x * y;
        }
        public float multiple(float x, float y)
        {
            Console.WriteLine("x is " + x + "\ny is " + y);
            return x * y;
        }

        public string multiplyTable(int n)
        {
            string text = "";
            
            for (int i = 1; i <= 12; i++) {
                // text = text + ""+n+" x "+i+" = "+(n*i)+"\n";
                // or use Assignment operator += 
                text += n+" x "+i+" = "+(n*i)+"\n";

            }
            return text;
        }

        public int factorial(int n = 5) // can set default parameter
        {
            int result = n;
            for (int i = 1; i < n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
