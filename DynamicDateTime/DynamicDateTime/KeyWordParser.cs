using System;

namespace DynamicDateTime
{
    public class KeyWordParser : IKeyWordParser
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
