<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.dll</Reference>
</Query>

/****************************************************************************** 	
	Date: 		2022-12-16
	Title: 		URL 編解碼問題
	Reference: 	https://www.huanlintalk.com/2014/02/url-encoding-solved.html
******************************************************************************/
void Main()
{
	//string input = "http://whotest.com/a b/c?phone=+886&name=M. Tsai&msg=say:'hello?!'";
	string input = "Microsoft Print to PDF-( 中文測試  )";
    Console.WriteLine("input: \n{0}", input);
	
	string encoded = System.Web.HttpUtility.UrlEncode(input);
	string decoded = System.Web.HttpUtility.UrlDecode(encoded);
	Console.WriteLine(new string('=', 70));
	Console.WriteLine("HttpUtility.UrlEncode/UrlDecode: \n{0}\n{1}", encoded, decoded);

	encoded = Uri.EscapeUriString(input);
    decoded = Uri.UnescapeDataString(encoded);                      
    Console.WriteLine(new string ('=', 70));
    Console.WriteLine("Uri.EscapeUriString/UnescapeDataString: \n{0}\n{1}", encoded, decoded);
    
    encoded = Uri.EscapeDataString(input);
    decoded = Uri.UnescapeDataString(encoded);
    Console.WriteLine(new string('=', 70));
    Console.WriteLine("Uri.EscapeDataString/UnescapeDataString: \n{0}\n{1}", encoded, decoded);
}

// Define other methods and classes here