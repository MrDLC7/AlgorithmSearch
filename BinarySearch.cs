using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSearch
{
    internal class BinarySearch : AlgorithmSearch
    {
        private long _time;         //  Час виконання
        private string? _result;    //  Результат
        private long _step = 0;         //  Кроки

        public long _Time { get => _time; set => _time = value; }
        public string? _Result { get => _result; set => _result = value; }
        public long _Step { get => _step; set => _step = value; }

        public BinarySearch(Numbers[] numbers, long target)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int left = 0;
            int right = numbers.GetLength(0);
            while (left < right)
            {
                _Step++;
               int mid = left + (right - left) / 2;
                if (numbers[mid].value == target)
                {
                    _Result = $"+{numbers[mid].value}\nІндекс: {numbers[mid].index}\nХеш-код: {numbers[mid].hash}";

                    stopwatch.Stop();
                    _Time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                    return;
                }
                if (numbers[mid].value < target) 
                {
                    left = mid + 1;
                }
            }


            stopwatch.Stop();
            _Time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));

            _Result = "Не знайдено";
        }
    }
}
