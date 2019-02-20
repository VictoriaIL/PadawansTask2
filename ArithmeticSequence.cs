using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count < 0)
            {
                throw new ArgumentException();
            }
            int result = 0;
            try
            {
                int i = 0;
               
                while (i < count)
                {
                    result += number + i * add;
                    i++;
                }
            }
            catch( OverflowException)
            {
                throw new OverflowException();
            }
            return result;
        }
    }
}
