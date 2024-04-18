using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSearch
{
    internal class Print : AlgorithmSearch
    {
        //  Загальне виведення дій (Лог)
        static public string InfoLog(string name, long time, string unit)
        {
            return $"{name}\nЧас: {time} {unit}.\n\n";
        }

        //  Виведення дій пошуку (Лог)
        static public string InfoLog(string name, string details, long time, string unit, string? result, long step)
        {
            return $"{name}\nЧас пошуку: {time} {unit}.\nРезультат: {result}\nКількість кроків: {step}\n\n";
        }

        //  Очищення (Лог)
        static public string InfoLogReset()
        {
            return "";
        }

        //  Виведення списку (Список)
        static public string InfoList(Numbers[] nums)
        {
            string output = string.Empty;
            output += "Номер\t\t\tХеш-код\n";
            foreach (var item in nums)
            {
                output += $"+{item.value}\t\t{item.hash}\n";
            }
            return output;
        }

        //  Очищення списку
        static public string InfoListReset()
        {
            return "";
        }

        //  Розділення "Лог" після кожної виконаної дії
        static public string InfoLogSeparation()
        {
            string temp = "---------------------------------------------------------";
            return $"\n{temp}\n{temp}\n\n";
        }
    }
}
