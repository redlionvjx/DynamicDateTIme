using System;

namespace DynamicDateTime.KeyWordParsers
{
    public class SpecialSDCParser : IKeyWordParser
    {
        public DateTime ParseDate(string dateExpression, DateTime dependentDate = new DateTime())
        {
            throw new NotImplementedException();
        }

        public bool ShouldParseDate(string dateExpression)
        {
            throw new NotImplementedException();
        }
    }
}
