<Query Kind="Statements" />

Console.WriteLine("1 + 2 - 3 * 4 / 5");

var num = 1 + 2 - 3 * 4 / 5;
num.Dump();	

string apple = "Mac, iphone, ipad, ";
apple.Dump();

string hp = "EliteBook, ";
hp.Dump();

string company = apple + hp;
company.Dump();

List<string> menuIds = new List<string>()
{
    "01418838647e49738488b842796d31d5",
    "01948d4e92dc4f229f282e96740a6510"
};

string menuIdsStr = string.Format("|{0}|", string.Join("|", menuIds));
menuIdsStr.Dump();

DataTable dt = new DataTable();
dt.Columns.Add("FirstName", Type.GetType("System.String"));
dt.Columns.Add("LastName", Type.GetType("System.String"));
dt.Columns.Add("Phone", Type.GetType("System.String"));

DataRow dr = dt.NewRow();
dr["FirstName"] = "Kuo";
dr["LastName"] = "Ray";
dr["Phone"] = "02-2612-3456";
dt.Rows.Add(dr);

dt.Dump();



List<int> numbers = new List<int> () { 1, 2, 3};
numbers.Dump();

foreach(var number in numbers) {
	number.Dump();
}