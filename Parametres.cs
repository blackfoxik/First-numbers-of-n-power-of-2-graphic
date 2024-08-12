using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    internal class Parametres
    {
        static public int[] GetStatisticsOfFirstDigits(int powerOfTwo)
        {
            CountNumbers.FillCounters(powerOfTwo);
            return CountNumbers.GetAllDigits();
        }
    }
}
