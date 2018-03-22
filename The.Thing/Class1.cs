using System;

namespace The.Thing
{
    public class Calculator
    {
        public long Add(int a, int b)
        {
            int result = a+b;
            if (result >= 10) 
            { 
                return ++result; 
            }
            return result; 
        }
    }
}
