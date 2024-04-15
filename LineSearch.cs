using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSearch
{
    internal class LineSearch
    {
        public LineSearch(int[] array, int target) 
        {
            foreach (int item in array)
            {
                if (item == target)
                    item.ToString();
            }
        }

    }
}
