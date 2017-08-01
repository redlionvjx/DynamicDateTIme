using System;
using DynamicDateTime.DateModel;
using DynamicDateTime.VariableModels;

namespace DynamicDateTime.VariableParsers
{
    public class YearParser : IVariableParser
    {
        /// <summary>
        /// Parse the year variable
        /// </summary>
        /// <param name="dateVariable">The string to parse</param>
        /// <returns>Returns a dynamic date with the parsed date</returns>
        public DynamicDate ParseVariable(string dateVariable)
        {
            if (!ShouldParseVariable(dateVariable))
            {
                return new DynamicDate()
                {
                    Error = $"Incorrect Year Variable. Could not parse Year Variable = '{dateVariable}'"
                };
            }

            if (dateVariable.Equals(YearVariable.CurrentYear, StringComparison.InvariantCultureIgnoreCase))
                return ParseCurrentYear();

            if (dateVariable.Equals(YearVariable.LastYear, StringComparison.InvariantCultureIgnoreCase))
                return ParseLastYear();

            if (dateVariable.Equals(YearVariable.NextYear, StringComparison.InvariantCultureIgnoreCase))
                return ParseNextYear();

            if (dateVariable.Equals(YearVariable.StartYear, StringComparison.InvariantCultureIgnoreCase))
                return ParseStartYear();

            if (dateVariable.Equals(YearVariable.StartLastYear, StringComparison.InvariantCultureIgnoreCase))
                return ParseStartLastYear();

            if (dateVariable.Equals(YearVariable.StartNextYear, StringComparison.InvariantCultureIgnoreCase))
                return ParseStartNextYear();

            if (dateVariable.Equals(YearVariable.EndYear, StringComparison.InvariantCultureIgnoreCase))
                return ParseEndYear();

            if (dateVariable.Equals(YearVariable.EndLastYear, StringComparison.InvariantCultureIgnoreCase))
                return ParseEndLastYear();

            if (dateVariable.Equals(YearVariable.EndNextYear, StringComparison.InvariantCultureIgnoreCase))
                return ParseEndNextYear();

            return new DynamicDate()
            {
                Error = $"Incorrect Year Variable. Could not parse Year Variable = '{dateVariable}'"
            };
        }

        /// <summary>
        /// Checks if the year variable should be parsed
        /// </summary>
        /// <param name="dateVariable">The string to parse</param>
        /// <returns>Returns true if the date variable is parsable</returns>
        public bool ShouldParseVariable(string dateVariable)
        {
            if (string.IsNullOrWhiteSpace(dateVariable)) return false;

            return !string.IsNullOrWhiteSpace(dateVariable) &
                   (dateVariable.Equals(YearVariable.CurrentYear, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(YearVariable.NextYear, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(YearVariable.LastYear, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(YearVariable.EndYear, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(YearVariable.StartYear, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(YearVariable.StartLastYear, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(YearVariable.StartNextYear, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(YearVariable.EndLastYear, StringComparison.InvariantCultureIgnoreCase) |
                    dateVariable.Equals(YearVariable.EndNextYear, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private DynamicDate ParseCurrentYear()
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
        private DynamicDate ParseNextYear()
        {
            return new DynamicDate()
            {
                Date = DateTime.Today.AddYears(1)
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private DynamicDate ParseLastYear()
        {
            return new DynamicDate()
            {
                Date = DateTime.Today.AddYears(-1)
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private DynamicDate ParseStartYear()
        {
            var currentDate = DateTime.Today;

            return new DynamicDate()
            {
                Date = new DateTime(currentDate.Year, 1, 1)
            };
        }
        
        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private DynamicDate ParseEndYear()
        {
            var currentDate = DateTime.Today;

            return new DynamicDate()
            {
                Date = new DateTime(currentDate.Year, 12, 31)
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private DynamicDate ParseEndLastYear()
        {
            var currentDate = DateTime.Today.AddYears(-1);

            return new DynamicDate()
            {
                Date = new DateTime(currentDate.Year, 12, 31)
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private DynamicDate ParseEndNextYear()
        {
            var currentDate = DateTime.Today.AddYears(1);

            return new DynamicDate()
            {
                Date = new DateTime(currentDate.Year, 12, 31)
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private DynamicDate ParseStartLastYear()
        {
            var currentDate = DateTime.Today.AddYears(-1);

            return new DynamicDate()
            {
                Date = new DateTime(currentDate.Year, 1, 1)
            };
        }

        /// <summary>
        /// Returns a DynamicDate with Today's date
        /// </summary>
        /// <returns>DynamicDate object</returns>
        private DynamicDate ParseStartNextYear()
        {
            var currentDate = DateTime.Today.AddYears(1);

            return new DynamicDate()
            {
                Date = new DateTime(currentDate.Year, 1, 1)
            };
        }
    }
}
