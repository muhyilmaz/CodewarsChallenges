using System;
using System.Collections.Generic;
using System.Text;

namespace CodewarsChallenges.challenges
{
    class RgbToHex
    {
        public RgbToHex(int r, int g, int b)
        {
            string toWriteText = $"Red: {r}, Green:{g} and Blue: {b} are RGB values. Their HEX code is {Rgb(r, g, b)}";
            PrintHex(toWriteText);
        }

        public void PrintHex(string toWriteTex)
        {
            Console.WriteLine(toWriteTex);
        }

        public static string Rgb(int r, int g, int b)
        {

            r = r > 255 ? 255 : r < 0 ? 0 : r;
            g = g > 255 ? 255 : g < 0 ? 0 : g;
            b = b > 255 ? 255 : b < 0 ? 0 : b;

            string result = string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);

            return result;
        }
    }
}
