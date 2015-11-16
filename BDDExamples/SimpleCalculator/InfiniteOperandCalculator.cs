using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InfiniteOperandCalculator
    {
        List<int> _operands = new List<int>();

        public void EnterOperand(int operand)
        {
            _operands.Add(operand);
        }

        public int Add()
        {
            if (_operands.Count < 2) throw new InvalidOperationException("Add operation requires a minimum of 2 operands");

            var sum = _operands.Sum();
            return sum;
        }

        public void Clear()
        {
            _operands.Clear();
        }
    }
}
