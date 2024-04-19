using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSearch
{
    internal class HashTableSearch : AlgorithmSearch
    {
        private long _time;             //  Час виконання
        private long _time_sort;        //  Час сортування
        private string? _result;        //  Результат
        private long _step;             //  Кроки

        public long _Time { get => _time; set => _time = value; }
        public long _Time_Sort { get => _time_sort; set => _time_sort = value; }
        public string? _Result { get => _result; set => _result = value; }
        public long _Step { get => _step; set => _step = value; }

        public HashTableSearch(Numbers[] numbers, long target)
        {
            _Step = 0;
            Stopwatch stopwatch = new Stopwatch();

            SortNumbers(numbers);
            stopwatch.Restart();

            int hash = Math.Abs(HashFunction(target.ToString()));
            int index = hash % numbers.GetLength(0);

            if (numbers[index].value == target)
            {
                _Step++;
                _Result = $"+{numbers[index].value}\nХеш-код: {numbers[index].hash}";

                stopwatch.Stop();
                _Time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
            }
            else
            {
                _Step++;
                stopwatch.Stop();

                _Result = "Не знайдено";
                _Time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
            }
        }

        //  Сортування по хешкодам
        private void SortNumbers(Numbers[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();

            Array.Sort(numbers, (a, b) => a.id.CompareTo(b.id));
            stopwatch.Stop();
            _Time_Sort = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Хеш-код для номера
        private int HashFunction(string input)
        {
            unchecked
            {
                int hash = 5381;
                foreach (char c in input)
                {
                    hash = ((hash << 5) + hash) + c;
                }
                return hash;
            }
        }
    }
}
