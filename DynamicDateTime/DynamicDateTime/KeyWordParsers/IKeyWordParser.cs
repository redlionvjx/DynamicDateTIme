using System;
using DynamicDateTime.DateModel;

namespace DynamicDateTime.KeyWordParsers
{
    public interface IKeyWordParser
    {
        DynamicDate ParseDate(string dateExpression, DateTime dependentDate = default(DateTime));

        bool ShouldParseDate(string dateExpression);
    }
}
