<Query Kind="Program" />

/*
	Date: 2022-10-14
	Title: List Contains如何判斷是否存在
	Reference: https://www.zendei.com/article/76794.html
	如果List集合是引用類型的對象的話，則是依據對象的引用地址是否相同來判斷，
	如果被判斷對象的引用地址不在List集合中，那即使這個對象的所有屬性與List集合中的某個元素所有屬性一致，返回結果也是為false。
*/

void Main()
{
	var john = new Person { name = "John", age = 20 };
	//var mary = new Person { name = "John", age = 20 }; //No Mary
	var mary = john;
	
	var people = new List<Person> {};	
	
	people.Add(john);
	
	if(people.Contains(mary))
	{	
		Console.WriteLine("has Mary");
	}
	else
	{
		Console.WriteLine("No Mary");
	}
	
	people.Dump();
}

// Define other methods and classes here
class Person
{
	public string name;
	public int age;
}