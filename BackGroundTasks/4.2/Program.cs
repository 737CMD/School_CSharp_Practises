using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    enum Month
    {
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec,
    }
    class MatrixWeather
    {
        Month month;
        static int[] daysInMonthes = { 31, 29 /*Leap year*/, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int monthFirstDay;
        int[,] temperature;
        public MatrixWeather()
        {
            temperature = new int[6, 7];
            FillMonth(this);
        }
        public MatrixWeather(int monthFirstDay, Month month)
        {
            this.month = month;
            this.monthFirstDay = monthFirstDay;
            temperature = new int[6, 7];
            FillMonth(this);
        }
        public int MonthFirstDay
        {
            get
            {
                return  monthFirstDay;
            }
            set
            {
                this.temperature = ReFillMonth(this, value - monthFirstDay);
                monthFirstDay = (value + 42) % 7;
            }
        }
        public int[,] Temperature { get => temperature; }
        public int CountDaysWithTemperatureThatEqualsTwenty
        {
            get
            {
                int x = 0;
                for (int i = monthFirstDay; i < daysInMonthes[(int)(month)] + monthFirstDay; ++i)
                {
                    x += temperature[i / 7, i % 7] == 20 ? 1 : 0;
                }
                return 0;
            }
        }
        public int MaxDelta()
        {
            int maxDelta = -19;
            for (int i = 1 + monthFirstDay; i < daysInMonthes.Length + monthFirstDay; ++i)
            {
                if (Math.Abs(temperature[i / 7, i % 7] - temperature[(i-1) / 7, (i-1) % 7]) > maxDelta)
                {
                    maxDelta = temperature[i / 7, i % 7] - temperature[(i - 1) / 7, (i - 1) % 7];
                }
            }
            return maxDelta;
        }
        public int MaxDelta(out int maxDelta)
        {
            maxDelta = -19;
            for (int i = 1 + monthFirstDay; i < daysInMonthes.Length + monthFirstDay; ++i)
            {
                if (Math.Abs(temperature[i / 7, i % 7] - temperature[(i-1) / 7, (i-1) % 7]) > maxDelta)
                {
                    maxDelta = temperature[i / 7, i % 7] - temperature[(i - 1) / 7, (i - 1) % 7];
                }
            }
            return maxDelta;
        }
        static void FillMonth(MatrixWeather MX)
        {
            Random random = new Random();
            for (int i = MX.monthFirstDay; i < MatrixWeather.daysInMonthes[(int)(MX.month)] + MX.monthFirstDay; ++i)
            {
                MX.temperature[i / 7, i % 7] = random.Next(16, 35 /*Subtropics*/);
            }
        }
        public int CountDays
        {
            get
            {
                return daysInMonthes[(int)MonthFirstDay];
            }
        }
        static int[,] ReFillMonth(MatrixWeather MX, int DayDelta)
        {
            DayDelta += 42;
            DayDelta %= 7;

            MatrixWeather result = new MatrixWeather((MX.monthFirstDay + DayDelta) % 7, MX.month);
            int j = result.monthFirstDay;
            for (int i = MX.monthFirstDay; i < MatrixWeather.daysInMonthes[(int)(MX.month)] + MX.monthFirstDay; ++i)
            {
                result.temperature[j / 7, j % 7] = MX.temperature[i / 7, i % 7];
                ++j;
            }
            return result.temperature;
        }
        public override string ToString()
        {
            string result = "Mo\tTu\tWe\tTh\tFr\tSa\tSu"; 
            for (int i = 0; i < 42; ++i)
            {
                if (i % 7 == 0)
                {
                    result += "\n";
                }
                if (temperature[i / 7, i % 7] != 0) //day exists
                {
                    result +=  "(" +  + (i - monthFirstDay) + "," + temperature[i / 7, i % 7] + ")";
                }
                result += "\t";
            }
            return result;
        }
        public static bool operator <(MatrixWeather first, MatrixWeather second)
        {
            return first.month < second.month;
        }
        public static bool operator >(MatrixWeather first, MatrixWeather second)
        {
            return first.month > second.month;
        }
        public static MatrixWeather operator++(MatrixWeather  mv)//Prefix increment
        {
            mv.MonthFirstDay = mv.MonthFirstDay + 1;
            return mv;
        }
        public static  MatrixWeather operator --(MatrixWeather mv)//Prefix decrement
        {
            mv.MonthFirstDay = mv.MonthFirstDay - 1;
            return mv;
        }
        public static implicit operator bool (MatrixWeather mv)
        {
            foreach(int i in mv.temperature)
            {
                if (i < 25)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator &(MatrixWeather first, MatrixWeather second)
        {
            for(int i = 0; i < 42; ++i)
            {
                if (first[i / 7, 7 % 7] != second[i / 7, i % 7])
                {
                    return false;
                }
            }
            return true;
        }
        public int this[int i, int j]
        {
            get
            {
                return temperature[i, j];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input month number");
            int monthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input month first day (0 - Mo... 6 - Su)");
            int monthFirstDay = int.Parse(Console.ReadLine());
            MatrixWeather mw = new MatrixWeather(monthFirstDay, (Month)(monthFirstDay));
            Console.WriteLine(mw.ToString());
            Console.WriteLine("Input new month first day (0 - Mo... 6 - Su)");
            int NewmonthFirstDay = int.Parse(Console.ReadLine());
            mw.MonthFirstDay = NewmonthFirstDay;
            Console.WriteLine(mw.ToString());
            Console.WriteLine("CountDaysWithTemperatureThatEqualsTwenty");
            Console.WriteLine(mw.CountDaysWithTemperatureThatEqualsTwenty);
            Console.WriteLine("CountDays");
            Console.WriteLine(mw.CountDays);
            Console.WriteLine("Input week number");
            int weekNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input weekday number");
            int weekdayNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Temperature on this day:" + mw[weekNumber, weekdayNumber]);

        }
    }
}
