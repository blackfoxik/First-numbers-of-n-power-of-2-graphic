using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    internal class CountNumbers
    {
        enum Digits
        {
            k1 = 0,
            k2 = 1,
            k3 = 2,
            k4 = 3,
            k5 = 4,
            k6 = 5,
            k7 = 6,
            k8 = 7,
            k9 = 8
        }
        public static int[] digitsArray = new int [9];
        static public void FillCounters(int N)
        {

            for (int i = 0; i <= N; i++)
            {
                double Power = Math.Pow(2, i);
                CountDigit(GetFirstDigit(Power));
            }
        }
        static public int GetFirstDigit(double number)
        {
            while (number >= 10) number /= 10;
            return (int)number;
        }
        static public void CountDigit(int digit)
        {
            switch (digit)
            {
                case 1:
                    digitsArray[(int)Digits.k1]++;
                    break;
                case 2:
                    digitsArray[(int)Digits.k2]++;
                    break;
                case 3:
                    digitsArray[(int)Digits.k3]++;
                    break;
                case 4:
                    digitsArray[(int)Digits.k4]++;
                    break;
                case 5:
                    digitsArray[(int)Digits.k5]++;
                    break;
                case 6:
                    digitsArray[(int)Digits.k6]++;
                    break;
                case 7:
                    digitsArray[(int)Digits.k7]++;
                    break;
                case 8:
                    digitsArray[(int)Digits.k8]++;
                    break;
                case 9:
                    digitsArray[(int)Digits.k9]++;
                    break;
                default:
                    break;
            }
        }
        static public int GetDigitCount(int digit)
        {
            return digitsArray[digit - 1];
        }
    }
}
