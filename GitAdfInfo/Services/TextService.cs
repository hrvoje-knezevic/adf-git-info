using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitAdfInfo.Services
{
    public class TextService
    {
        public string ReverseString(string input)
        {
            if (input == null)
            {
                throw new ArgumentException("The input string must not be null.");
            }

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
