<Query Kind="Program" />

void Main()
{
	string[] separatingStrings = { "~"};
	var reason = "5CG9B15N4Q|HW issue (No disk available)~5CG2383T74|Loss~5CG2383T75|Loss~";
	var splitReason = reason.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
	//splitReason.Dump();
	
	foreach(var each in splitReason){
		var start = each.IndexOf("|");
		
		//start.Dump();
		
		var ret = each.Substring(start+1);
		//ret.Dump();
	}
	
	var result =  GetReason("5CG2383T74",reason);
	result.Dump();
}

// Define other methods and classes here
private string GetReason(string sn, string reason)
{
    var ret = string.Empty;
    string[] separatingStrings = { "~" };
    //var reason = "5CG2383T74|Loss~5CG2383T75|Loss~5CG9B15N4Q|HW issue (No disk available)~";
    var splitReason = reason.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
    
    foreach (var eachReason in splitReason)
    {
        if (eachReason.Contains(sn))
        {
            var start = eachReason.IndexOf("|");
            ret = eachReason.Substring(start + 1);
            break;
        }
    }

    return ret;
}