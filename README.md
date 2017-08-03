# DynamicDateTime
Library to aid testers create dynamic date times based on variables/keywords. 

### Nuget is available at https://www.nuget.org/packages/DynamicDateTime/1.0.0

## Usage
Dynamic date parses known date variables/keywords:

| Variables     | Definition | Current Date | Result|
| ------------- | ------------- | ------------- | ------------- | 
| `Today`  | Current day  | 8/2/2017 | 8/2/2017 |
| `Yesterday`  | Day before today  | 8/2/2017 | 8/1/2017 |
| `Tomorrow`  | Day after today  | 8/2/2017 | 8/3/2017 |
| `LastWeek`  | 7 days before today  | 8/2/2017 | 7/26/2017 |
| `NextWeek`  | 7 days after today  | 8/2/2017 | 8/9/2017 |
| `CurrentMonth`  | Current month  | 8/2/2017 | 8/2/2017 |
| `LastMonth`  | 1 month before today  | 8/2/2017 | 7/2/2017 |
| `NextMonth`  | 1 month after today  | 8/2/2017 | 9/2/2017 |
| `MidMonth`  | 15th of the month  | 8/2/2017 | 8/15/2017 |
| `StartMonth`  | 1st of the month  | 8/2/2017 | 8/1/2017 |
| `EndMonth`  | Last of the month  | 8/2/2017 | 8/31/2017 |
| `NextQuarter`  | 90 days before today  | 8/2/2017 | 10/31/2017 |
| `LastQuarter`  | 90 days after today  | 8/2/2017 | 5/4/2017 |
| `CurrentYear`  | Current year  | 8/2/2017 | 8/2/2017 |
| `NextYear`  | 1 year after today  | 8/2/2017 | 8/2/2018 |
| `LastYear`  | 1 year before today  | 8/2/2017 | 8/12/2016 |
| `StartYear`  | 1st of this year  | 8/2/2017 | 1/1/2017 |
| `StartNextYear`  | 1st of 1 year after today  | 8/2/2017 | 1/1/2018 |
| `StartLastYear`  | 1st of 1 year before today  | 8/2/2017 | 1/1/2016 |
| `EndYear`  | End of this year  | 8/2/2017 | 12/31/2017 |
| `EndNextYear`  | End of 1 year after today  | 8/2/2017 | 12/31/2018 |
| `EndLastYear`  | End of 1 year before today  | 8/2/2017 | 12/31/2016 |

Use the DynamicParser to parse variables/keywords or use the variable parsers individually:

```
DateTime expectedDate = DateTime.Today;
DynamicDate actualDate = DynamicParser.GetDate(MonthVariable.CurrentMonth);
Assert.AreEqual(expectedDate, actualDate.Date);
```

or 

```
DateTime expectedDate = DateTime.Today.AddDays(1);
DynamicDate actualDate = DayParser.ParseVariable("tomorrow");
Assert.AreEqual(expectedDate, actualDate.Date);
```
