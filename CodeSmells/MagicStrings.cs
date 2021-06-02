using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    class MagicStrings
    {
        public int Compute(ComputationId id)
        {
            if (id == ComputationId.RightComputation)
            {
                // Compute for "R"
                return 1;
            }
            else if (id == ComputationId.LeftComputation)
            {
                // Compute for "L"
                return 2;
            }

            throw new Exception($"Unknown id {id}");
        }
    }

    enum ComputationId
    {
        RightComputation, LeftComputation
    }
}
