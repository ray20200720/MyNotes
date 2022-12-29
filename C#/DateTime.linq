<Query Kind="Program" />

void Main()
{
	//取得今日/昨日的日期
	var today = DateTime.Now;		//=> 今日日期
	today.Dump();
	
	DateTime.Now.AddDays(-1); 	//=> 昨日日期
	DateTime.Now.AddDays(-90);	//=> 3個月
	
	//把日期轉成yyyyMMdd 
	//ex...20120104
	var newDateTime = DateTime.Now.ToString("yyyyMMdd");
	Console.WriteLine(newDateTime);
 
	//把日期轉成yyyy/MM/dd => DateTime.Now.ToString("yyyy/MM/dd")
	//ex...2022/01/04
	newDateTime = DateTime.Now.ToString("yyyy/MM/dd");
		
	DateTime day = DateTime.Parse("2022-11-15 09:52:30");
	//Console.WriteLine(day.ToString());
	//Console.WriteLine(day.ToShortDateString());
	
	string dateString = "20221115";
	var tdrDate = DateTime.ParseExact(dateString, "yyyyMMdd", null).ToString("yyyy-MM-dd");
	//Console.WriteLine(tdrDate.ToString());
	
	//var beginDateOfUnitWTProdLog = "";
	var beginDateOfUnitWTProdLog = "20220818";
	DateTime beginDate;
	
    try
    {
		if (string.IsNullOrEmpty(beginDateOfUnitWTProdLog))
        {
            beginDate = DateTime.Now.AddDays(-90);
        }
        else
        {
            var parseResult = DateTime.ParseExact(beginDateOfUnitWTProdLog, "yyyyMMdd", null);
            if (parseResult > DateTime.Now.AddDays(-90))
            {
                beginDate = parseResult;
            }else
            {
                beginDate = DateTime.Now.AddDays(-90);
            }
        }
		Console.WriteLine(beginDate.ToString());
		
    }
	catch(Exception ex)
    {
		throw ex;
	}
	
}

// Define other methods and classes here
