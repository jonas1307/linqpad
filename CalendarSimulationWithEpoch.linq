<Query Kind="Program" />

void Main()
{
	var year = 2023;
	
	var month = 11;
	
	var daysInFebruary = year % 4 == 0 ? 29 : 28;
	
	var daysInMonth = new int[] { 31, daysInFebruary, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
	
	var daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
	
	var monthIndex = month - 1;
	
	var result = new Dictionary<int, string>();
	
	for (var i = 1; i <= daysInMonth[monthIndex]; i++)
	{
		var monthDate = new DateTime(year, month, i, 0, 0, 0, DateTimeKind.Utc);
		var epochDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		
		var daysSinceEpoch = (monthDate - epochDate).Days;
		
		var dayOfWeekIndex = daysSinceEpoch % 7;
		
		result.Add(daysSinceEpoch, daysOfWeek[dayOfWeekIndex]);
	}
	
	result.Dump();
}

// You can define other methods, fields, classes and namespaces here