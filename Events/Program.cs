using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalClock digiclock = new DigitalClock();

            digiclock.SecondChanged += Log;

            digiclock.Start();
        }


        static void Log(object o, TimeInfo e)
        {
            if (e.Second < 10)
            {
                Console.ForegroundColor = DigitalClock.GetRandomConsoleColor();
                Console.WriteLine($"Digital Clock Time: {e.Hour}:{e.Minute}:0{e.Second}");
            }
            else
            {
                Console.ForegroundColor = DigitalClock.GetRandomConsoleColor();
                Console.WriteLine($"Digital Clock Time: {e.Hour}:{e.Minute}:{e.Second}");
            }
        }
    }
}