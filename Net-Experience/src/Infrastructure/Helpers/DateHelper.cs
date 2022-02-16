using System;

namespace Net.Experience.Common.Helpers
{
    public static class DateHelper
    {
        public static readonly string OnlyDatePattern = "yyyy-MM-dd";

        public static readonly string OnlyTimePattern = "hh:mm:ss";

        public static readonly string DateTimePattern = "yyyy-MM-ddThh:mm:ss";

        public static readonly DateTime MaxDateTime = DateTime.MaxValue;

        public static DateTime CurrenctDateUTC()
        {
            return DateTime.UtcNow.Date;
        }
    }
}
