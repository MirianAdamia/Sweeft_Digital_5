using System;

namespace Sweeft_Digital_5 { 
     public class Program
    {
        static int countVariants(int stearsCount)
        {
            if (stearsCount <= 2)
            {
                return stearsCount;
            }           
            else
            {
                return countVariants(stearsCount - 2) + countVariants(stearsCount - 1);
            }
        }
        static void Main(string[] args)
        {
           int result = countVariants(12);
           Console.WriteLine(result);
        }
    }
}
