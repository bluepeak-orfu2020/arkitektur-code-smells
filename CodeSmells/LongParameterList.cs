using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    class LongParameterList
    {
        public int Compute(string userId, bool isAdmin, bool allowUpdates, bool applyTax, string category1, string category2)
        {
            int result = userId.Length;

            if (isAdmin)
            {
                result *= 1000;
            }
            if (allowUpdates)
            {
                result -= 50;
            }
            if (applyTax && category1 == "export")
            {
                result = 0;
            }
            if (category2 != null)
            {
                result += 10;
            }

            return result;
        }
    }
}
