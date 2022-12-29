<Query Kind="Program" />

void Main()
{
	Product oberon = new Product { name = "Oberon", price = 0, version = "1.0" };	
	oberon.Dump();
	
	//Product a2 = oberon;
	//a2.name = "A2";
	//
	//a2.Dump();
	//oberon.Dump();
	
	UpgradeProduct a2 = new UpgradeProduct();
	a2.compatible = true;
	a2.name = "A2";
	a2.price = 12;
	a2.version = "2.0";
	a2.Dump();
	
	Product LNO = new UpgradeProduct();
	LNO.name = "LNO";
	LNO.price = 24;
	//LNO.compatible = true;
	
}

// Define other methods and classes here
class Product
{
	public string name;
	public int price;
	public string version;
}

class UpgradeProduct : Product
{
	public bool compatible;
}


