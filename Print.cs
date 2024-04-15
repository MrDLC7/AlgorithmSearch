using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSearch
{
    internal class Print : AlgorithmSearch
    {
        static public string InfoLog(string name, string details, long time, string unit)
        {
            return $"{name}\n{details}: {time} {unit}.\n";
        }
        static public string InfoLogReset()
        {
            return "";
        }

        static public string InfoList(Numbers[] nums)
        {
            string output = string.Empty;
            output += "Номер\t\t\t" + "Ключ\t" + "Хеш-код\n";
            foreach (var item in nums)
            {
                output += $"+{item.value}\t\t{item.key}\t {item.hash}\n";
            }
            return output;
        }
        static public string InfoListReset()
        {
            return "";
        }
    }
}
