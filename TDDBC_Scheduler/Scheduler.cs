using System;
namespace TDDBC_Scheduler
{
    public class SchedulerSetting
    {
        private string timeString;
        public SchedulerSetting()
        {
        }

        public SchedulerSetting(string hour, string minutes, string second)
        {
            timeString = buildTimeString(hour, minutes, second);
        }

        public string GetTimeString()
        {
            return timeString;
        }

        public bool TaskIsExcutable(string hour, string minutes, string second)
        {
            string givenTime = buildTimeString(hour, minutes, second);

            return timeString == givenTime;
        }

        private string buildTimeString(string hour, string minutes, string second)
        {
            return second + " " + minutes + " " + hour;

        }
    }
}
