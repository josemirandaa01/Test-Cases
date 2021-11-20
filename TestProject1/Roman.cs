using System;

namespace Decimales_a_romanos
{
    class Program
    {
       

        public static string Convert(int n)
        {
            if ((n < 0) || (n > 3999))
            {
                return "Inserte un número válido";

            }
            if (n < 1)
            {
                return string.Empty;
            }
            if (n >= 1000)
            {
                return "M" + Convert(n - 1000);
            }
            if (n >= 900)
            {
                return "CM" + Convert(n - 900);
            }
            if (n >= 500)
            {
                return "D" + Convert(n - 500);
            }
            if (n >= 400)
            {
                return "CD" + Convert(n - 400);
            }
            if (n >= 100)
            {
                return "C" + Convert(n - 100);
            }
            if (n >= 90)
            {
                return "XC" + Convert(n - 90);
            }
            if (n >= 50)
            {
                return "L" + Convert(n - 50);
            }
            if (n >= 40)
            {
                return "XL" + Convert(n - 40);
            }
            if (n >= 10)
            {
                return "X" + Convert(n - 10);
            }
            if (n >= 9)
            {
                return "IX" + Convert(n - 9);
            }
            if (n >= 5)
            {
                return "V" + Convert(n - 5);
            }
            if (n >= 4)
            {
                return "XC" + Convert(n - 4);
            }
            if (n >= 1)
            {
                return "I" + Convert(n - 1);
            }
            throw new ArgumentOutOfRangeException("error");
        }

    }
}
