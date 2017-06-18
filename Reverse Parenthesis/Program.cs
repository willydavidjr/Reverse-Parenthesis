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
            List<string> lstResult = new List<string>();
            char[] strResultRegex = Regex.Replace(s, "[A-Za-z]", "").Where(x => x != ' ').ToArray();
            bool blCheckInside = false;

            if (string.Join("", strResultRegex) == "()()")
                blCheckInside = true;
            if (strResultRegex.Where(x => x == '(' || x == ')').Count() == 0)
                return s;

            string[] strTemp = s.Split(new char[] { '(', ')' });
            string[] strEven = new string[] { };

            if (blCheckInside == false)
            {
                strEven = strTemp.Select((a, b) => new { Value = a, Index = b })
              .Where(x => x.Index % 2 != 0).Select(y => new string(y.Value.Reverse().ToArray())).Reverse().ToArray();
            }
            else
            {
                strEven = strTemp.Select((a, b) => new { Value = a, Index = b })
            .Where(x => x.Index % 2 != 0).Select(y => new string(y.Value.Reverse().ToArray())).ToArray();

                //string[] strTempFor = new string[] { };


            }

            string[] strEvenForElseStatement = strTemp.Select((a, b) => new { Value = a, Index = b })
            .Where(x => x.Index % 2 != 0).Select(y => new string(y.Value.Reverse().ToArray())).ToArray();

            string[] strOdd = strTemp.Select((a, b) => new { Value = a, Index = b })
            .Where(x => x.Index % 2 == 0).Select(y => y.Value).ToArray();

            int intCounter = 0;
            int intCounterOdd = 0;
            var intCounterParenthesis1 = s.Where(x => x == '(').Count();
            int intCounterParenthesis = s.Where(x => x == '(').Count();
            int intCountParent = 0;
            if (strResultRegex[0] == strResultRegex[1])
            {
                for (int item = 0; item < strTemp.Length; item++)
                {
                    if (item % 2 == 0)
                    {
                        lstResult.Add(strOdd[intCounterOdd]);

                        intCounterOdd++;
                        if (intCountParent <= intCounterParenthesis)
                        {
                            intCountParent++;
                        }
                        else
                        {
                            intCountParent++;
                        }
                    }
                    else
                    {
                        lstResult.Add(strEven[intCounter]);

                        intCounter++;
                        if (intCountParent <= intCounterParenthesis)
                        {
                            intCountParent++;
                        }
                        else
                        {
                            intCountParent++;
                        }
                    }
                }
            }
            else
            {
                for (int item = 0; item < strTemp.Length; item++)
                {
                    if (item % 2 == 0)
                    {
                        lstResult.Add(strOdd[intCounterOdd]);

                        intCounterOdd++;
                        if (intCountParent <= intCounterParenthesis)
                        {
                            intCountParent++;
                        }
                        else
                        {
                            intCountParent++;
                        }
                    }
                    else
                    {
                        lstResult.Add(strEvenForElseStatement[intCounter]);

                        intCounter++;
                        if (intCountParent <= intCounterParenthesis)
                        {
                            intCountParent++;
                        }
                        else
                        {
                            intCountParent++;
                        }
                    }
                }
            }
            //string[] strResult = strTemp
            //.Select(y => new string(y.Reverse().ToArray()))
            //.Reverse()
            //.ToArray();

            /*
             ?????? reverseParentheses(string s) {
            return ???????(s);
            }

            string reverse(string ?) {
                var l = s.LastIndexOf('(');
                ?? (l == -1) return s;
                ??? r = s.IndexOf(')', l);
                ??? arr = s.Substring(l + ?, r - l - 1).ToCharArray();
                ?????.Reverse(arr);
                return reverse(?.Substring(0, l) + new ??????(arr) + s.Substring(r + ?));
            } 
             */


            string result = string.Join("", lstResult.ToArray());
            return result;
        }
    }
}
