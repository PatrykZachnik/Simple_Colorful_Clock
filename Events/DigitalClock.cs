using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class DigitalClock : Clock
    {
        
        public static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor)); // wyciagam zdefiniowane numery kolorów
            return (ConsoleColor)consoleColors.GetValue(RandomColor.Next(1,15)); // Kolory zdefiniowane są w numerach 0 do 15, z uwagi na to że czarny tekst na czarnym tle jest nieczytelny wyrzucam wartość 0
        }

        public static Random RandomColor = new Random(); // losowa liczba.


    }
}
