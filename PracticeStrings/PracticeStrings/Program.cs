// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("aaaabbc");
revert("aaaabbc");

Console.WriteLine("Input your word!");
String input = Console.ReadLine();
revert(input);
static void revert(String s)
{
    StringBuilder sb = new StringBuilder("", 50);
    for(int i = s.Length - 1; i >=0 ; i--)
    {
        sb.Append(s[i]);
    }
    Console.WriteLine(sb);
}
