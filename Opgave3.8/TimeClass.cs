using System.Security.Principal;

namespace Opgave3._8
{
    public struct TimeClass
    {
        private int hour;
        private int minute;
        private int secondsSinceMidnight;
        private int maxSeconds = 86400;

        public TimeClass(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.secondsSinceMidnight = second;
        }

        public int Hour
        {
            get { return secondsSinceMidnight / 3600; }

            set
            {
                int hour = value;
                int temp = secondsSinceMidnight % 3600;
                secondsSinceMidnight = (temp + hour * 3600) % maxSeconds;

            }

        }
        public int Minute
        {
            get { return (secondsSinceMidnight % 3600) / 60; }

            set
            {
                int minute = value;
                int temp = secondsSinceMidnight % 3600;
                secondsSinceMidnight = (temp + minute * 60) % maxSeconds;
            }
        }

        public int Second
        {
            get { return secondsSinceMidnight % 60; }

            set
            {
                int second = value;
                int temp = secondsSinceMidnight % 60;
                secondsSinceMidnight = (temp + second) % maxSeconds;
            }
        }
    }
}