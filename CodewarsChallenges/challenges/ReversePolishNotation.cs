using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodewarsChallenges.challenges
{
    class ReversePolishNotation
    {
        public static double Evaluate(String str)
        {
            double result = 0.0;
            var strSplitted = str.Split(' ');
            if (String.IsNullOrEmpty(str))
            {
                return result;

            }
            else if (strSplitted.Length < 2 && Double.TryParse(strSplitted[0], out result))
            {
                return result;
            }
            else
            {
                Stack stack = new Stack();

                for (int i = 0; i < strSplitted.Length; i++)
                {
                    if (double.TryParse(strSplitted[i], out result))
                    {
                        stack.Push(result);
                    }
                    else
                    {

                        double arg1 = (double)stack.Pop();
                        double arg2 = (double)stack.Pop();

                        if (strSplitted[i] == "+")
                            result = arg1 + arg2;

                        if (strSplitted[i] == "-")
                            result = arg1 - arg2;

                        if (strSplitted[i] == "*")
                            result = arg1 * arg2;

                        if (strSplitted[i] == "/")
                            result = arg2 / arg1;

                        stack.Push(result);
                    }

                }


                result = (double)stack.Pop();
                return result;
            }
        }
    }
}
