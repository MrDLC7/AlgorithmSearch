using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSearch
{
    internal class HashTableSearch : AlgorithmSearch
    {
        private long _time;         //  Час виконання
        private string? _result;    //  Результат
        private long _step;         //  Кроки

        public long _Time { get => _time; set => _time = value; }
        public string? _Result { get => _result; set => _result = value; }
        public long _Step { get => _step; set => _step = value; }

        public HashTableSearch(Numbers[] numbers, long target)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();





            stopwatch.Stop();
            _Time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));

            _Result = "Не знайдено";
        }
    }
}
