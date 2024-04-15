using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSearch
{
    internal class LinearSearch : AlgorithmSearch
    {
        private long _time;
        private string? _result;
        private long _step;

        public long _Time { get; set; }
        public string _Result { get; set; }
        public long _Step { get; set; }

        public LinearSearch(Numbers[] numbers, long target) 
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (Convert.ToInt64(numbers[i].value) == target)
                {
                    _Step = i;
                    _Result = numbers[i].value;

                    stopwatch.Stop();
                    _Time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                    return;
                }
            }

            stopwatch.Stop();
            _Time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));

            _Result = "Не знайдено";
            _Step = numbers.GetLength(0);
        }

    }
}
