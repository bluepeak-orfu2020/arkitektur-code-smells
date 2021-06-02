using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    class Comments2020
    {
        public void Compute()
        {
            // Assign inital value to x
            double x = 5;

            // Compute the power of x
            double result = Math.Pow(x, 2);

            // Print the result of the computation
            Console.WriteLine($"Result: {result}");
        }
    }

    /*
      This version of the Comments class represents the state
      of the same class as above but one year later.

      Notice that the computation has changed but the developer
      missed to update the comment. As this point the code is
      quite confusing. The result will be the square root of x
      but is that the value the customer wants???
    */
    class Comments2021
    {
        public void Compute()
        {
            // Assign inital value to x
            double x = 5;

            // Compute the power of x
            double result = Math.Sqrt(x);

            // Print the result of the computation
            Console.WriteLine($"Result: {result}");
        }
    }
}
