using System;
using DynamicDateTime.DateModel;
using DynamicDateTime.VariableModels;

namespace DynamicDateTime.VariableParsers
{
    public static class MonthParser
    {
        /// <summary>
        /// Parse the month variable
        /// </summary>
        /// <param name="dateVariable"></param>
        /// <returns>Returns a dynamic date with the parsed date</returns>
        public static DynamicDate ParseVariable(string dateVariable)
        {
            if (!ShouldParseVariable(dateVariable))
            {
                return new DynamicDate()
                {
                    Error = $"Incorrect Month Variable. Could not parse Month Variable = '{dateVariable}'"
                };
            }

            if (dateVariable.Equals(MonthVariable.CurrentMonth, StringComparison.InvariantCultureIgnoreCase))
                return ParseCurrentMonth();

            if (dateVariable.Equals(MonthVariable.NextMonth, StringComparison.InvariantCultureIgnoreCase))
                return ParseNextMonth();

            if (dateVariable.Equals(MonthVariable.LastMonth, StringComparison.InvariantCultureIgnoreCase))
                return ParseLastMonth();

            if (dateVariable.Equals(MonthVariable.MidMonth, StringComparison.InvariantCultureIgnoreCase))
                return ParseMidMonth();

            if (dateVariable.Equals(MonthVariable.StartMonth, StringComparison.InvariantCultureIgnoreCase))
                return ParseStartMonth();

            if (dateVariable.Equals(MonthVariable.EndMonth, StringComparison.InvariantCultureIgnoreCase))
                return ParseEndMonth();

            return new DynamicDate()
            {
                Error = $"Incorrect Month Variable. Could not parse Month Variable = '{dateVariable}'"
            };
        }

        /// <summary>
        /// Checks if the month variable should be parsed
        /// </summary>
        /// <param name="dateVariable"></param>
        /// <returns>Returns true if the date variable is parsable</returns>
        public static bool ShouldParseVariable(string dateVariable)
        {
            if (string.IsNullOrWhiteSpace(dateVariable)) return false;

            return !string.IsNullOrWhiteSpace(dateVariable) &
                   (dateVariable.Equals(MonthVariable.CurrentMonth, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(MonthVariable.EndMonth, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(MonthVariable.LastMonth, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(MonthVariable.MidMonth, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(MonthVariable.NextMonth, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(MonthVariable.StartMonth, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private static DynamicDate ParseCurrentMonth()
        {
            return new DynamicDate()
            {
                Date = DateTime.Today
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private static DynamicDate ParseNextMonth()
        {
            return new DynamicDate()
            {
                Date = DateTime.Today.AddMonths(1)
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private static DynamicDate ParseLastMonth()
        {
            return new DynamicDate()
            {
                Date = DateTime.Today.AddMonths(-1)
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private static DynamicDate ParseMidMonth()
        {
            var currentDate = DateTime.Today;

            return new DynamicDate()
            {
                Date = new DateTime(currentDate.Year, currentDate.Month, 15)
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private static DynamicDate ParseStartMonth()
        {
            var currentDate = DateTime.Today;

            return new DynamicDate()
            {
                Date = new DateTime(currentDate.Year, currentDate.Month, 1)
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private static DynamicDate ParseEndMonth()
        {
            var currentDate = DateTime.Today;
            var lastDay = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);

            return new DynamicDate()
            {
                Date = new DateTime(currentDate.Year, currentDate.Month, lastDay)
            };
        }
    }
}
