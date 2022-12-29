<Query Kind="Program" />

void Main()
{
	string settingLine = "A";
	//string settingLine = "C";
	//string settingLine = "D";
	
	string currentLine = "C1D"; // Line = "C"或"D" 都會Match
	
	var str = new Regex(settingLine).IsMatch(currentLine);
	str.Dump();
	
	var subString = new Regex(settingLine).IsMatch(currentLine.Substring(0,1));
	subString.Dump();
}

// Define other methods and classes here
