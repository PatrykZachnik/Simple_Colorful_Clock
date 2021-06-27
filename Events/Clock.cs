using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{
    class Clock
    {
        //private int second = 0;

        public delegate void SecondChangedHandler(object clock, TimeInfo timeInfo);

        public event SecondChangedHandler SecondChanged;
        public void Start()
        {
            for (; ; )
            {
                Thread.Sleep(1000);
                DateTime now = DateTime.Now;

                TimeInfo timeInfoEventArgs = new TimeInfo(now.Hour, now.Minute, now.Second);

                if (SecondChanged != null)
                {
                    SecondChanged(this, timeInfoEventArgs);
                }

            }
        }
    }
}