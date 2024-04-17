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
        private long _time;             //  Час виконання
        private long _time_sort;        //  Час сортування
        private string? _result;        //  Результат
        private long _step;             //  Кроки

        public long _Time { get => _time; set => _time = value; }
        public long _Time_Sort { get => _time_sort; set => _time_sort = value; }
        public string? _Result { get => _result; set => _result = value; }
        public long _Step { get => _step; set => _step = value; }

        public BinarySearch(Numbers[] numbers, long target)
        {
            _Step = 0;
            Stopwatch stopwatch = new Stopwatch();

            SortNumbers(numbers);
            stopwatch.Restart();

            int left = 0;
            int right = numbers.GetLength(0) - 1;
            while (left <= right)
            {
                _Step++;
               int mid = left + (right - left) / 2;
                if (numbers[mid].value == target)
                {
                    stopwatch.Stop();
                    _Result = $"+{numbers[mid].value}\nХеш-код: {numbers[mid].hash}";
                    _Time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                    return;
                }
                else if (numbers[mid].value < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            stopwatch.Stop();
            _Result = "Не знайдено";
            _Time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        public void SortNumbers(Numbers[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();

            Array.Sort(numbers, (a, b) => a.value.CompareTo(b.value));
            stopwatch.Stop();
            _Time_Sort = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }
    }
}
