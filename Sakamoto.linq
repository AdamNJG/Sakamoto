<Query Kind="Expression">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

public static string FindDayFromDate( string date ) {
	
	string[] dateSplit = date.Split("-");
	
  	int d = int.Parse(dateSplit[0]);
  	int m = int.Parse(dateSplit[1]);
    int y = int.Parse(dateSplit[2]);
	
	int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 }; 
	
    y -= (m < 3) ? 1 : 0; 
          
    var day = ( y + y/4 - y/100 + y/400 + t[m-1] + d) %7;
						 
  	var result = string.Empty;
  	switch(day)
	{
	  case 1:
		result = "Monday";
		break;
	  case 2:
		result = "Tuesday";
		break;
	  case 3:
		result = "Wednesday";
		break;
	  case 4:
		result = "Thursday";
		break;
	  case 5:
		result = "Friday";
		break;
	  case 6:
		result = "Saturday";
		break;
	  case 7:
		result = "Sunday";
		break;
	}
  
  return result;
}
	string dateString = "13-2-2020";
	System.Globalization.CultureInfo enGB = new System.Globalization.CultureInfo("en-GB");
	DateTime dateTime = System.DateTime.Parse(dateString, enGB);

	Console.WriteLine(dateTime.DayOfWeek);
	Console.WriteLine(FindDayFromDate(dateString));

