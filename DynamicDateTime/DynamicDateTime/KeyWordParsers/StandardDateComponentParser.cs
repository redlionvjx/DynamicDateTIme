using System;
using DynamicDateTime.DateModel;
using DynamicDateTime.KeyWordModels;

namespace DynamicDateTime.KeyWordParsers
{
    public class StandardDateComponentParser : IKeyWordParser
    {
        /// <summary>
        /// Parses the date
        /// </summary>
        /// <param name="dateExpression">The date expression</param>
        /// <param name="dependentDate">The dependent date</param>
        /// <returns>Returns the date</returns>
        public DynamicDate ParseDate(string dateExpression, DateTime dependentDate = new DateTime())
        {
            if(!ShouldParseDate(dateExpression)) return new DynamicDate()
            {
                Error = $"Could not parse date expression = {dateExpression}"
            }; 

            return new DynamicDate()
            {
                Date = DateTime.Now
            };
        }

        /// <summary>
        /// Verifiies if the string can be parsed
        /// </summary>
        /// <param name="dateExpression">The date expression</param>
        /// <returns></returns>
        public bool ShouldParseDate(string dateExpression)
        {
            return !string.IsNullOrWhiteSpace(dateExpression) & 
                ( dateExpression.ToLower().Contains(StandardDateComponent.Day) 
                | dateExpression.ToLower().Contains(StandardDateComponent.Month) 
                | dateExpression.ToLower().Contains(StandardDateComponent.Year));
        }

        private int ParseDay(string dateExpression, DateTime dependentDate = new DateTime())
        {
            return 0;
        }

        private int ParseMonth(string dateExpression, DateTime dependentDate = new DateTime())
        {
            return 0;
        }

        private int ParseYear(string dateExpression, DateTime dependentDate = new DateTime())
        {
            return 0;
        }
    }
}
