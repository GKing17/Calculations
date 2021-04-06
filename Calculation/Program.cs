using System;
using System.Diagnostics;

namespace Calculation
{
    public static class Program
    {
        public static int FoundMax2nd_Original(int[] inputArray)
        {
            if (inputArray.Length <= 1)
            {
                throw new ArgumentException("Array lenth is equal to zero or too shor for identifiying second large integer.", nameof(inputArray));
            }

            if (inputArray == null)
            {
                throw new NullReferenceException(nameof(inputArray));
            }

            foreach (int number in inputArray)
            {
                if (number == int.MaxValue || number == int.MinValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), "Argument is equal to Int.MinValue or Int.MinValue.");
                }
            }

            int buffer;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = 0; j < inputArray.Length - i - 1; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        buffer = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = buffer;
                    }
                }
            }

            for (int i = inputArray.Length - 1; i >= 1; i--)
            {
                if(inputArray[i] > inputArray[i - 1])
                {
                    return inputArray[i - 1];
                }
            }

            return inputArray[^2];
        }
    }
}
