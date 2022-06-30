using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc  : Interface1
    {
        public float Calculate(float a, float b, string c)
        {
            switch (c)
            {
                case "+":
                    return a + b;

                case "-":
                    return a - b;

                case "*":
                    return a * b;

                case "/":
                    return a / b;

                case "tan":
                    
                    return (float)Math.Tan(a );

                case "log":
                    
                    return (float)Math.Log(a, 2);
                    


            }
            return 0;

        }
    }
}

