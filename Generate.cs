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
        private long _time;

        public long _Time { get; set; }


        public Generate(Numbers[] numbers, int size)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();

            int first = 380, second, thirtd, fouth;
            string hash;
            stopwatch.Start();

            for (int i = 0; i < size; i++)
            {
                numbers[i].key = -1;
            }

            for (int i = 0; i < size;)
            {
                second = NumCode() * 10 + random.Next(10);
                thirtd = random.Next(999);
                fouth = random.Next(999);
                numbers[i].value = NumToString(first) + NumToString(second) + NumToString(thirtd) + NumToString(fouth);

                hash = (Convert.ToInt64(numbers[i].value) % 10204).GetHashCode().ToString();
                numbers[i].hash = hash;
                long n = (Convert.ToInt64(hash) % size);
                if (numbers[Convert.ToInt64(hash) % size].key == -1)
                {
                    numbers[Convert.ToInt64(hash) % size].key = Convert.ToInt64(hash) % size;
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

        private string NumToString(int num)
        {
            return num.ToString("D3");
        }

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