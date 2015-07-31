using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core
{
    public interface IFizzBuzz
    {
        string Generate(int max);
    }

    public class FizzBuzzImpl : IFizzBuzz
    {
        public string Generate(int max)
        {
            string result = String.Empty;

            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result += "FizzBuzz,";
                else if (i % 3 == 0)
                    result += "Fizz,";
                else if (i % 5 == 0)
                    result += "Buzz,";
                else
                    result += i + ",";
            }

            return result;
        }
    }
}
