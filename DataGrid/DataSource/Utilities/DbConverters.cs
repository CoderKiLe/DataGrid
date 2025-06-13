using DataGrid.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.DataSource.Utilities
{
    public static class DbConverters
    {
        public static DateTime ParseDateTime(string dateTime)
        {
            // Try exact ISO 8601 format first
            if (DateTime.TryParseExact(dateTime, "o", CultureInfo.InvariantCulture,
                DateTimeStyles.AssumeUniversal, out var date))
            {
                return date;
            }

            // default
            return DateTime.Parse(dateTime);
        }

        public static Priority ParsePriority(string priorityString)
        {
            if (Enum.TryParse<Priority>(priorityString, out var priority))
            {
                return priority;
            }

            // default value
            return Priority.Medium;
        }
    }
}
