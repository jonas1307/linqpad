<Query Kind="Program" />

void Main()
{
	var year = 2023;
	
	var unixEpochs = new int[12];
	
	for (var i = 0; i < 12; i++)
	{
		var month = new DateTime(year, (i + 1), 1, 0, 0, 0, DateTimeKind.Utc);
		
		var epoch = month - DateTime.UnixEpoch;
		
		unixEpochs[i] = (int)epoch.TotalSeconds;
	}
	
	unixEpochs.Dump();
}

// You can define other methods, fields, classes and namespaces here