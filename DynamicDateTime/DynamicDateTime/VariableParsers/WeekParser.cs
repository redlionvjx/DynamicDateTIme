using System;
using DynamicDateTime.DateModel;
using DynamicDateTime.VariableModels;

namespace DynamicDateTime.VariableParsers
{
    public class WeekParser : IVariableParser
    {
        /// <summary>
        /// Parse the week variable
        /// </summary>
        /// <param name="dateVariable"></param>
        /// <returns></returns>
        public DynamicDate ParseVariable(string dateVariable)
        {
            if (!ShouldParseVariable(dateVariable))
            {
                return new DynamicDate()
                {
                    Error = $"Incorrect Quarter Variable. Could not parse Quarter Variable = '{dateVariable}'"
                };
            }

            if (dateVariable.Equals(WeekVariable.LastWeek, StringComparison.InvariantCultureIgnoreCase))
                return ParseLastWeek();

            if (dateVariable.Equals(WeekVariable.NextWeek, StringComparison.InvariantCultureIgnoreCase))
                return ParseNextWeek();

            return new DynamicDate()
            {
                Error = $"Incorrect Quarter Variable. Could not parse Quarter Variable = '{dateVariable}'"
            };
        }

        /// <summary>
        /// Checks if the week variable should be parsed
        /// </summary>
        /// <param name="dateVariable"></param>
        /// <returns></returns>
        public bool ShouldParseVariable(string dateVariable)
        {
            if (string.IsNullOrWhiteSpace(dateVariable)) return false;

            return !string.IsNullOrWhiteSpace(dateVariable) &
                   (dateVariable.Equals(WeekVariable.LastWeek, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(WeekVariable.NextWeek, StringComparison.InvariantCultureIgnoreCase));
        }

        private DynamicDate ParseNextWeek()
        {
            return new DynamicDate()
            {
                Date = DateTime.Today.AddDays(7)
            };
        }

        private DynamicDate ParseLastWeek()
        {
            return new DynamicDate()
            {
                Date = DateTime.Today.AddDays(-7)
            };
        }
    }
}
