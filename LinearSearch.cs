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
        private long _time;         //  Час виконання
        private string? _result;    //  Результат
        private long _step;         //  Кроки

        public long _Time { get => _time; set => _time = value; }
        public string? _Result { get => _result; set => _result = value; }
        public long _Step { get => _step; set => _step = value; }

        public LinearSearch(Numbers[] numbers, long target) 
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                //  Якщо знайдено зберегти кількість кроків, номер, індекс, хеш-код, час
                if (Convert.ToInt64(numbers[i].value) == target)
                {
                    _Step = i;
                    _Result = $"+{numbers[i].value}\nІндекс: {numbers[i].index}\nХеш-код: {numbers[i].hash}";

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
