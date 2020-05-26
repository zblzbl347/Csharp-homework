using System;
using System.Threading;

namespace clock
{
    class Clock
    {
        public delegate void ClickHanlder();
        public delegate void AlarmHanlder();
        public event ClickHanlder ClockClick;
        public event AlarmHanlder ClockAlarm;
        public int hour, minute, second = 0;
        public void SetAlarm(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
        public void Click()
        {
            ClockClick();
        }
        public void Alarm()
        {
            ClockAlarm();
        }
        public void Start()
        {
            while (true)
            {
                Click();
                int nowhour = DateTime.Now.Hour;
                int nowminute = DateTime.Now.Minute;
                int nowsecond = DateTime.Now.Second;
                if (hour == nowhour && minute == nowminute && second == nowsecond)
                {
                    Alarm();
                }
                Thread.Sleep(1000);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();
            myClock.ClockClick += Ticking;
            myClock.ClockAlarm += Alarming;
            myClock.SetAlarm(13, 02, 00);
            myClock.Start();
        }
        public static void Alarming()
        {
            Console.WriteLine("叮铃铃铃！");
        }
        public static void Ticking()
        {
            Console.WriteLine("嘀嗒");
        }
    }
}