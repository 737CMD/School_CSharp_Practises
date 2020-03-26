using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_10._09__Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            double r = 64.100, pl = 7.8932597f, pr = 100000000000f;
            decimal dec = 18500.5m;
            byte sl = 4, p = 16;
            string s = "AMD";
            string name;
            decimal f, fl = 3.20000m;
            Console.ResetColor();
            Console.Write("Введите ваше имя:\t");
            name = Console.ReadLine();
            Console.Write("\nВедите дробное число\t");
            f = Math.Floor(decimal.Parse((Console.ReadLine()).Replace(',', '.')));
            Console.WriteLine("\n\nПривет, " + name + "!\n********************************** \n" +
                "*\tЯ твой компьютер!\t* \n**********************************\nУ меня следующие характеристики:" +
                "\nПроцессор \t\t" + s + " с разрядностью(частотой) " + "{0:F2}" + "GHz\n" +
                "Моя Память\t\t" + p.ToString() + "GB (доступно " + "{1:F0}" + "%)\n" +
                "Жесткий диск\t\t" + sl.ToString() + "Tb\n" +
                "Тип системы\t\t" + "{2:N0}" + "-разрядная ОС\n\n" +
                "Моя Производительность\t" + pr.ToString("E0") + " оп/сек\n" +
                "Индекс произ-ти \t" + "{3:N0}" + "\n" +
                "Моя Стоимость\t\t" + /*dec.ToString() + */  (dec).ToString().Replace('.',',') + " ₽", fl, (pl * 10), r, f);

            }
    }
}
