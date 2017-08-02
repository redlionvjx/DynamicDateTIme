using System;
using DynamicDateTime.DateModel;
using DynamicDateTime.VariableModels;

namespace DynamicDateTime.VariableParsers
{
    public static class QuarterParser
    {
        /// <summary>
        /// Parse the quarter variable
        /// </summary>
        /// <param name="dateVariable"></param>
        /// <returns></returns>
        public static DynamicDate ParseVariable(string dateVariable)
        {
            if(!ShouldParseVariable(dateVariable))
            {
                return new DynamicDate()
                {
                    Error = $"Incorrect Quarter Variable. Could not parse Quarter Variable = '{dateVariable}'"
                };
            }

            if (dateVariable.Equals(QuarterVariable.LastQuarter, StringComparison.InvariantCultureIgnoreCase))
                return ParseLastQuarter();

            if (dateVariable.Equals(QuarterVariable.NextQuarter, StringComparison.InvariantCultureIgnoreCase))
                return ParseNextQuarter();

            return new DynamicDate()
            {
                Error = $"Incorrect Quarter Variable. Could not parse Quarter Variable = '{dateVariable}'"
            };
        }

        /// <summary>
        /// Checks if the quater variable should be parsed
        /// </summary>
        /// <param name="dateVariable"></param>
        /// <returns></returns>
        public static bool ShouldParseVariable(string dateVariable)
        {
            if (string.IsNullOrWhiteSpace(dateVariable)) return false;

            return !string.IsNullOrWhiteSpace(dateVariable) &
                   (dateVariable.Equals(QuarterVariable.LastQuarter, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(QuarterVariable.NextQuarter, StringComparison.InvariantCultureIgnoreCase));
        }

        private static DynamicDate ParseNextQuarter()
        {
            return new DynamicDate()
            {
                Date = DateTime.Today.AddDays(90)
            };
        }

        private static DynamicDate ParseLastQuarter()
        {
            return new DynamicDate()
            {
                Date = DateTime.Today.AddDays(-90)
            };
        }
    }
}
