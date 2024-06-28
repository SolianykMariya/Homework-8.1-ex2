using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        public static DateTime UnixTimeToDateTimeConverter(long unixTime)
        {
            DateTime epoch = new DateTime(1900,1,1,0,0,0,DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть секунди:");
            long unix = Convert.ToInt32(Console.ReadLine());
            if (unix > 9223372036854775807)
            {
                Console.WriteLine("Занадто велике значення!!! Введіть число не більше, ніж 9223372036854775807");
            }
            
            DateTime date = UnixTimeToDateTimeConverter(unix);
            Console.WriteLine($"Переведені дата та час: {date}");
        }
    }
}
