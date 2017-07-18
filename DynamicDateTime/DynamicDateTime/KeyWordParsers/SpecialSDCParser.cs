using System;
using DynamicDateTime.DateModel;

namespace DynamicDateTime.KeyWordParsers
{
    public class SpecialSDCParser : IKeyWordParser
    {
        public DynamicDate ParseDate(string dateExpression, DateTime dependentDate = new DateTime())
        {
            throw new NotImplementedException();
        }

        public bool ShouldParseDate(string dateExpression)
        {
            throw new NotImplementedException();
        }
    }
}
