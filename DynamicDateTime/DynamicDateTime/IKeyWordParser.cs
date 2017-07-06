using System;

namespace DynamicDateTime
{
    public interface IKeyWordParser
    {
        DateTime ParseDate(string dateExpression, DateTime dependentDate = default(DateTime));

        bool ShouldParseDate(string dateExpression);
    }
}
