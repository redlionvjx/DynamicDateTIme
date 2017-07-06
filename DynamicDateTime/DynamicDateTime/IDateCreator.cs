
using System;

namespace DynamicDateTime
{
    public interface IDateCreator
    {
        DateTime CreateDate(int year, int month, int day);
    }
}
