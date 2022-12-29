<Query Kind="Program" />

void Main()
{
	int num = 1;
	int qty = 2; 		 //宣告時,不需要加上out
	int num2 = 5;
	Hello(num, out qty, num2); //傳參時,需加上out
	
	Console.WriteLine("Hello World: num is {0} quantity is {1}", num, qty);
	
}

// Define other methods and classes here
void Hello(int num, out int quantity, int num2) //定義函數時,需加上out
{	
	num = 3;
	quantity = 4;	//函數內部使用時,不需加上out
	Console.WriteLine("Hello World: num is {0}, quantity is {1}", num, quantity);
}
