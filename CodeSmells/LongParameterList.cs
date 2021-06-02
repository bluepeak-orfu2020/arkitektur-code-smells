using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    class LongParameterList
    {
        public void Callee()
        {
            Settings settings = new Settings()
            {
                IsAdmin = true,
                AllowUpdates = true,
                ApplyTax = false
            };
            new LongParameterList().Compute("abc", settings, "ca", "cb");
        }

        public int Compute(string userId, Settings settings, string category1, string category2)
        {
            int result = userId.Length;

            if (settings.IsAdmin)
            {
                result *= 1000;
            }
            if (settings.AllowUpdates)
            {
                result -= 50;
            }
            if (settings.ApplyTax && category1 == "export")
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

    class Settings
    {
        public bool IsAdmin { get; set; }
        public bool AllowUpdates { get; set; }
        public bool ApplyTax { get; set; }
    }
}
