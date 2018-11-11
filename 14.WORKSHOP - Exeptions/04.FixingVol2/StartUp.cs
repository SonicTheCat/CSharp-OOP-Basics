using System;

namespace _04.FixingVol2
{
    class StartUp
    {
        static void Main()
        {
            int num1, num2;
            int result;

            num1 = 30;
            num2 = 60;

            result = Convert.ToInt32(num1 * num2);
            Console.WriteLine(num1 + " x " + num2 + " = " + result);
        }
    }
}
