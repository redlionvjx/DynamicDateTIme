using System;
using DynamicDateTime.DateModel;

namespace DynamicDateTime.VariableParsers
{
    public interface IVariableParser
    {
        DynamicDate ParseVariable(string dateVariable);

        bool ShouldParseVariable(string dateVariable);
    }
}
