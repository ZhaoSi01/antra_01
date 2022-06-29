// First part
Console.WriteLine("sbyte, byte, short, ushort, int, uint, long");
Console.WriteLine("Size of sbyte:{0} ", sizeof(sbyte));
Console.WriteLine("Size of byte:{0} ", sizeof(byte));
Console.WriteLine("Size of short:{0} ", sizeof(short));
Console.WriteLine("Size of ushort:{0} ", sizeof(ushort));
Console.WriteLine("Size of int:{0} ", sizeof(int));
Console.WriteLine("Size of uint:{0} ", sizeof(uint));
Console.WriteLine("Size of long:{0} ", sizeof(long));
Console.WriteLine("Size of ulong:{0} ", sizeof(ulong));
Console.WriteLine("Size of float:{0} ", sizeof(float));
Console.WriteLine("Size of double:{0} ", sizeof(double));
Console.WriteLine("Size of decimal:{0} ", sizeof(decimal));
Console.WriteLine("MMMMMMMMMMMMMMMMMMMMM");

Console.WriteLine("Minimum:{0} of sbyte, Maximum:{1} sbyte", sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine("Minimum of int:{0} , Maximum  int:{1}", int.MinValue, int.MaxValue);
Console.WriteLine("Minimum decimal:{0} , Maximum decimal:{1} ", decimal.MinValue, decimal.MaxValue);

//Second part
Console.WriteLine("Please input the century");
String s = Console.ReadLine();
int i = Convert.ToInt32(s);

Console.WriteLine("Century = {0}, years = {1}, days = {2}, hours = {3}, minutes = {4}, seconds = {5} ",
    i, 100 * i, 365.24 * 100 * i,
    365.24 * 100 * i*24, 365.24 * 100 * i * 24 * 60,
    365.24 * 100 * i * 24 * 3600);


