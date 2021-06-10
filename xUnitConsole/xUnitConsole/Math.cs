using System;
using System.Collections.Generic;
using System.Text;

namespace xUnitConsole
{
    public class MathClass
    {
        public int Sum(int firstVar, int secondVar)
        {
            return firstVar + secondVar;
        }

        public int Minus(int firstVar, int SecondVar)
        {
            if(firstVar >= SecondVar)
            {
                return firstVar - SecondVar;
            }
            else
            {
                return SecondVar - firstVar;
            }
        }
    }
}
