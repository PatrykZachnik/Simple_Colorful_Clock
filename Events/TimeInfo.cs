using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class TimeInfo
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public TimeInfo(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
    }
}