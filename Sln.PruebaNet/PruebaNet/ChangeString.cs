using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet
{
    class ChangeString { 
        static void Main(string[] args)
        {

        }

        static string build(string input)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd','e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] letters = input.ToCharArray();
            string reverse = string.Empty;

            for (int i = 0; i < letters.Length; i++)
            {
                reverse += letters[i];
            }
            return reverse;
        }
    }
}
