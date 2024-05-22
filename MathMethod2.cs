using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method__Class_Assignment_2
{
    internal class MathMethod2
    {
        //First method that takes an integer
        public int MathOp (int number) 
        {
            return number +10;
        }
        //Second method that takes a decimal
        public int MathOp (decimal number)
        {
            //Convert the decimal to an int to perform math opration
            int newnum=Convert.ToInt32(number);
            return newnum *50;
        }
        //Third MathOp method that takes a string
        public int MathOp(string number)
        {
            //Convert the string to an int perform math opration 
            int newnum = Convert.ToInt32(number);
            return newnum %7;
        }
    }
}
