using System;
using System.Globalization;


namespace date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = new DateTime();
            // 01/01/0001 00:00:00
            Console.WriteLine(data);

            var dataNow = DateTime.Now;
            // Data Atual;
            Console.WriteLine(dataNow);

            var data3 = new DateTime(2020, 10, 12, 8, 23, 14);
            Console.WriteLine(data3);
            Console.WriteLine(data3.Year);
            Console.WriteLine(data3.Month);
            Console.WriteLine(data3.Day);
            Console.WriteLine(data3.Hour);
            Console.WriteLine(data3.Minute);
            Console.WriteLine(data3.Second);
            Console.WriteLine(data3.DayOfWeek);
            Console.WriteLine((int)data3.DayOfWeek);


            Console.WriteLine(dataNow); 
            var formatada = String.Format("{0:dd/MM/yy HH:mm:ss ffff z}", dataNow);
            Console.WriteLine(formatada);
            var formatada2 = String.Format("{0:t}", dataNow);
            Console.WriteLine(formatada2);

            Console.WriteLine(dataNow.AddDays(1));
            Console.WriteLine(dataNow.AddMonths(1));
            Console.WriteLine(dataNow.AddYears(1));
        
            // YYYY - MM - DD - HH - mm ss

            //Comparando Datas;

            //DateTime? dataNull = null;
            var dataComp = DateTime.Now;

            if(dataComp.Date == DateTime.Now.Date){
                Console.WriteLine("É Igual");
            }else{
                Console.WriteLine("Não é Igual");
            }

            //Globalização e Localização;
            var pt = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var cultureCurrent = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(String.Format("{0:D}", DateTime.Now));
            Console.WriteLine(DateTime.Now.ToString("D"));
            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", en));


            var dateTime = DateTime.UtcNow;
            //Sempre utilizar o utc caso trabalhar com apps globalizados;

            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToLocalTime());
            Console.WriteLine(dateTime.ToLocalTime());

            var timeZoneTokyo = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            Console.WriteLine(timeZoneTokyo);

            var horaTokyo = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZoneTokyo);
            //TimeZoneInfo.ConvertTimeToUtc
            Console.WriteLine(horaTokyo);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine("{0} \n{1} \n{2}", timezone.Id, timezone, TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
            //     Console.WriteLine("---------");
                
            // }

            //Timespan;

            var timeSpan = new TimeSpan(5,5,5,5,12);
            Console.WriteLine(timeSpan);

            // DateTime.DaysInMonth(YY,M) -> numero de dias em um mes
            // isWeekend DayOfWeek.Saturday -> verifica se é fim de semana;
            // isDayLightSavingTime() -> verifica horario de verão;
        }
    }
}
