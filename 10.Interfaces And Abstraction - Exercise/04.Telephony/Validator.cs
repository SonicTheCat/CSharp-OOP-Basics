using System;
using System.Linq;

namespace Telephony
{
    public class Validator
    {
        public static void Number(string number)
        {
            bool allNums = number.All(char.IsNumber);

            if (!allNums)
            {
                throw new ArgumentException("Invalid number!");
            }
        }

        public static void WebSite(string website)
        {
            bool containsNum = website.Any(char.IsNumber);

            if (containsNum)
            {
                throw new ArgumentException("Invalid URL!");
            }
        }
    }
}