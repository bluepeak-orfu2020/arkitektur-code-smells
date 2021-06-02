using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    class DeadCode
    {
        /*
            Example 1.
            The parameter "value2" is not used by the method.
            However, it still has to be provided everytime the
            method is called.
        
            This can cause confusion for the calling code as it
            expects different results when passing different
            values to "value2" but nothhing happens.

            Imagine the same scenario but the parameter is an
            object with a non-trivial initialization. Then the
            calling code would have to make an effort to call
            this method but get nothing for it.
         */
        public double Compute(int value1, int value2, int value3)
        {
            return Math.Sqrt(Math.Pow(value1, 2) * Math.Pow(value3, 2));
        }
    }

    /*
      In this class the method Main() calls a method that fetches
      information from somewhere. At some point in the past the
      implementation of Main changed from using CallToFirstService()
      to CallToOtherService(). The old code was left in the class
      ever if it is not used.

      Imagine now that the provider of "first service" contacts us
      and says that they are changing their code and we therefore
      need to update yours. We're not sure if we're using "first service"
      so we look in the code and find CallToFirstService(). Since
      the code exists in our repo we assume that it is use and spend
      time fixing CallToFirstService() only to later realise that 
      no one is called the method and we've just spent valuable
      time fixing something that will never be used.
    */
    class DeadCode2
    {
        public void Main()
        {
            Console.WriteLine($"The output is: {CallToOtherService()}");
        }

        private string CallToOtherService()
        {
            // Code that talks to "other service"
            return "";
        }

        private string CallToFirstService()
        {
            // Code that talks to "service"
            return "";
        } 
    }
}
