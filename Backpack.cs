using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backpack
{
    public class Backpack
    {
        public Backpack(int[] weight = null, int[] values = null, int maxCapacity = 10)
        {
            weight ??= new int[] { 5, 4, 3, 2, 2 };
            values ??= new int[] { 12, 10, 5, 8, 7 };

            _maxCapcity = maxCapacity;
            _weight = weight;
            _values = values;
        }

        public int[] _weight;
        public int[] _values;
        private int _maxCapcity;

        public int GetMaxPrices()
        {
            var arr = new int[_weight.Length + 1, _maxCapcity + 1];

            for (int i = 0; i <= _weight.Length; i++)
            {
                for (int j = 0; j <= _maxCapcity; j++)
                {
                    if(i == 0 || j == 0)
                    {
                        arr[i, j] = 0;
                    }
                    else
                    {
                        if(_weight[i-1] > j)
                        {
                            arr[i, j] = arr[i - 1, j];
                        }
                        else
                        {
                            var prev = arr[i - 1, j];
                            var f = _values[i - 1] + arr[i - 1, j - _weight[i - 1]];
                            arr[i, j] = Math.Max(prev,f);
                        }
                        
                    }
                }
            }
            // КНП элемент
            return arr[_weight.Length, _maxCapcity];
        }
    }
}
