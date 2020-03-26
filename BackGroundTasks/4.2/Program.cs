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
        int[,] temperature = new int[6, 7];
        public MatrixWeather()
        {
            FillMonth(this);
        }
        public MatrixWeather(int monthFirstDay, Month month)
        {
            this.month = month;
            this.monthFirstDay = monthFirstDay;
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
                ReFillMonth(this, value - monthFirstDay);
                monthFirstDay = value;
            }
        }
        public int[,] Temperature { get => temperature; }
        public int DaysWithTemperatureThatEqualsZero
        {
            get
            {
                int x = 0;
                for (int i = monthFirstDay; i < daysInMonthes[(int)(month)] + monthFirstDay; ++i)
                {
                    x += temperature[i / 7, i % 7] == 0 ? 1 : 0;
                }
                return 0;
            }
        }
        public int MaxDelta()
        {
            int maxDelta = -19;
            for (int i = 1 + monthFirstDay; i < DaysInMonthes.Length + monthFirstDay; ++i)
            {
                if (temperature[i / 7, i % 7] - temperature[(i-1) / 7, (i-1) % 7] > maxDelta)
                {
                    maxDelta = temperature[i / 7, i % 7] - temperature[(i - 1) / 7, (i - 1) % 7];
                }
            }
            return maxDelta;
        }
        public int MaxDelta(out int maxDelta)
        {
            maxDelta = -19;
            for (int i = 1 + monthFirstDay; i < daysInMonthes[(int)(month) + monthFirstDay; ++i)
            {
                if (temperature[i / 7, i % 7] - temperature[(i-1) / 7, (i-1) % 7] > maxDelta)
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
        static MatrixWeather ReFillMonth(MatrixWeather MX, int DayDelta)
        {
            MatrixWeather result = new MatrixWeather(MX.monthFirstDay + DayDelta, MX.month);
            for (int i = MX.monthFirstDay + DayDelta; i < MatrixWeather.daysInMonthes[(int)(MX.month)] + MX.monthFirstDay + DayDelta; ++i)
            {
                result.temperature[i / 7, i % 7] = MX.temperature[(i - DayDelta) / 7, (i - DayDelta) % 7];
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
