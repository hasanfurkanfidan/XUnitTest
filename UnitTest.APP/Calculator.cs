using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTest.APP
{
   public class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Extract(int a,int b)
        {
            if (a > b)
                return a - b;
            else if (b > a)
                return b - a;
            else
                return 0;
            
        }
    }
}
