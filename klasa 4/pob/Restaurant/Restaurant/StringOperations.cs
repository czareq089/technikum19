using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class StringOperations
    {
        public double CalculateCenterAndOffset(double width, string line)
        {
            return (Math.Floor(width) / 2 - line.Length) - 1;
        }
        public string PrintXChars(double x, char c)
        {
            string result = "";
            for (int i = 0; i < x; i++)
            {
                result += c;
            }
            return result;
        }
    }
}
