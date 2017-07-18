using System;

namespace DynamicDateTime.KeyWordParsers
{
    public interface IKeyWordParser
    {
        DateTime ParseDate(string dateExpression, DateTime dependentDate = default(DateTime));

        bool ShouldParseDate(string dateExpression);
    }
}
