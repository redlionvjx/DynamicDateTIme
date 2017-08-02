using System;
using DynamicDateTime.DateModel;
using DynamicDateTime.VariableModels;

namespace DynamicDateTime.VariableParsers
{
    public static class DayParser
    {
        /// <summary>
        /// Parse the day variable
        /// </summary>
        /// <param name="dateVariable">The string to parse</param>
        /// <returns>Returns a dynamic date with the parsed date</returns>
        public static DynamicDate ParseVariable(string dateVariable)
        {
            if (!ShouldParseVariable(dateVariable))
            {
                return new DynamicDate()
                {
                    Error = $"Incorrect Day Variable. Could not parse Day Variable = '{dateVariable}'"
                };
            }

            if (dateVariable.Equals(DayVariable.Today, StringComparison.InvariantCultureIgnoreCase))
                return ParseToday();

            if (dateVariable.Equals(DayVariable.Tomorrow, StringComparison.InvariantCultureIgnoreCase))
                return ParseTomorrow();

            if (dateVariable.Equals(DayVariable.Yesterday, StringComparison.InvariantCultureIgnoreCase))
                return ParseYesterday();

            return new DynamicDate()
            {
                Error = $"Incorrect Day Variable. Could not parse Day Variable = '{dateVariable}'"
            };
        }

        /// <summary>
        /// Checks if the day variable should be parsed
        /// </summary>
        /// <param name="dateVariable">The string to parse</param>
        /// <returns>Returns true if the date variable is parsable</returns>
        public static bool ShouldParseVariable(string dateVariable)
        {
            if (string.IsNullOrWhiteSpace(dateVariable)) return false;

            return !string.IsNullOrWhiteSpace(dateVariable) &
                (dateVariable.Equals(DayVariable.Today, StringComparison.InvariantCultureIgnoreCase) |
                dateVariable.Equals(DayVariable.Tomorrow, StringComparison.InvariantCultureIgnoreCase) |
                dateVariable.Equals(DayVariable.Yesterday, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private static DynamicDate ParseToday()
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
        private static DynamicDate ParseYesterday()
        {
            return new DynamicDate()
            {
                Date = DateTime.Today.AddDays(-1)
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private static DynamicDate ParseTomorrow()
        {
            return new DynamicDate()
            {
                Date = DateTime.Today.AddDays(1)
            };
        }
    }
}
