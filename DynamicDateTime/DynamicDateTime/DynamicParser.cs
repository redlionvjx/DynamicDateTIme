using DynamicDateTime.DateModel;
using DynamicDateTime.VariableParsers;

namespace DynamicDateTime
{
    public static class DynamicParser
    {
        //private DayParser DayParser => new DayParser();
        //private MonthParser MonthParser => new MonthParser();
        //private YearParser YearParser => new YearParser();
        //private WeekParser WeekParser => new WeekParser();
        //private QuarterParser QuarterParser => new QuarterParser();

        public static DynamicDate GetDate(string dateVariable)
        {
            if(DayParser.ShouldParseVariable(dateVariable))
            {
                return DayParser.ParseVariable(dateVariable);
            }

            if (MonthParser.ShouldParseVariable(dateVariable))
            {
                return MonthParser.ParseVariable(dateVariable);
            }

            if (YearParser.ShouldParseVariable(dateVariable))
            {
                return YearParser.ParseVariable(dateVariable);
            }

            if (WeekParser.ShouldParseVariable(dateVariable))
            {
                return WeekParser.ParseVariable(dateVariable);
            }

            if (QuarterParser.ShouldParseVariable(dateVariable))
            {
                return QuarterParser.ParseVariable(dateVariable);
            }

            return new DynamicDate()
            {
                Error = $"Incorrect Date Variable. Could not parse Date Variable = '{dateVariable}'"
            };
        }
    }
}
