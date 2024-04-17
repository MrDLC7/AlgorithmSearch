using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSearch
{
    internal class Generate : AlgorithmSearch
    {
        private long _time;             //  Час виконання

        public long _Time { get => _time; set => _time = value; }

        //  Генерація списку
        public Generate(Numbers[] numbers, int size)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();

            int first = 380, second, thirtd, fouth;         //  Частини номера
            int hash;
            long value;
            stopwatch.Start();

            //  Заповнення -1, - для унікальності номерів
            for (int i = 0; i < size; i++)
            {
                numbers[i].index = -1;
            }

            for (int i = 0; i < size;)
            {
                second = NumCode() * 10 + random.Next(10);
                thirtd = random.Next(999);
                fouth = random.Next(999);

                value = Convert.ToInt64(NumToString(first) + NumToString(second) + NumToString(thirtd) + NumToString(fouth));
                hash = (value % (size + 1)).GetHashCode();
                
                int n = (int)(hash % size);
                if (numbers[n].index == -1)
                {
                    numbers[n].index = n;
                    numbers[n].hash = hash;
                    numbers[n].value = value;
                }
                else
                {
                    continue;
                }
                i++;
            }
            stopwatch.Stop();
            _Time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Число в трьохсимвольний рядок
        private string NumToString(int num)
        {
            return num.ToString("D3");
        }

        //  Код оператора для номера
        private int NumCode()
        {
            int num = 0;
            Random random = new Random();

            switch (random.Next(10))
            {
                case 0:
                    num = 93;
                    break;
                case 1:
                    num = 96;
                    break;
                case 2:
                    num = 97;
                    break;
                case 3:
                    num = 98;
                    break;
                case 4:
                    num = 99;
                    break;
                case 5:
                    num = 73;
                    break;
                case 6:
                    num = 68;
                    break;
                case 7:
                    num = 67;
                    break;
                case 8:
                    num = 66;
                    break;
                case 9:
                    num = 50;
                    break;
                default:
                    num = 85;
                    break;
            }
            return num;
        }
    }
}