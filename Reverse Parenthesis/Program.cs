using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reverse_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string strPolynomial = @"23 * x ^ 8 + 53 * x - -97 * x ^ 5 - -44 * x ^ 2 + 36 * x - 85 * x ^ 3 - -23 * x";
            int result = derivative(strPolynomial, -4);

            string strReverseParenthesis = @"The ((quick (brown) (fox) jumps over the lazy) dog)";
            string resultReverse = reverseParentheses(strReverseParenthesis);

        }

        static int derivative(string polynomial, int x)
        {
            string[] intPolynomial = polynomial.Split(new string[] { " + ", " - " }, StringSplitOptions.None);
            return 1;
        }

        static string reverseParentheses(string s)
        {

            return reverse(s);

        }

        string reverse(string s)
        {
            var l = s.LastIndexOf('(');
            if (l == -1) return s;
            var r = s.IndexOf(')', l);
            var arr = s.Substring(l + r, r - l - 1).ToCharArray();
            Array.Reverse(arr);
            return reverse(s.Substring(0, l) + new string(arr) + s.Substring(r + l));
        }

    }
}
}
