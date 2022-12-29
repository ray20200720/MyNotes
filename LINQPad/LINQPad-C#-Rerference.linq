<Query Kind="Program">
  <Connection>
    <ID>264da496-e0d2-4a6e-aa2f-b3279c6aec5b</ID>
    <Persist>true</Persist>
    <Server>10.6.91.166</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>imes_ap</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAYZeU5oQ/QUWFgra6K80LgQAAAAACAAAAAAADZgAAwAAAABAAAAChQeIogti45VRODrvuGfUrAAAAAASAAACgAAAAEAAAAEJ1DTM7liE+g4YnZ0ILekwQAAAAHMuACPQs7Jo2aOyblmcFiBQAAAAY0JRcPv1zUGIQWmD45wp+cz+xiw==</Password>
    <Database>HPIMES</Database>
    <ShowServer>true</ShowServer>
  </Connection>
  <Reference>D:\Project\99_MyLab\Mix2008And2019\MyMES\DataModel\bin\Debug\DataModel.dll</Reference>
  <Namespace>DataModel</Namespace>
</Query>

void Main()
{
	CarrierInfo ci = new CarrierInfo() { CarrierId = "0001", Category = "Cassette", Customer = "HP", PartNo = "A123444", PdLine = "A", Status = "Finish", Type = "Pallet" };

    Console.WriteLine(ci.CarrierId);
    Console.WriteLine(ci.Category);
    Console.WriteLine(ci.Customer);
	
	List<CarrierInfo> carrierInfoList = new List<CarrierInfo>();
	carrierInfoList.Add(ci);
	
	carrierInfoList.Dump();	
}

// Define other methods and classes here
