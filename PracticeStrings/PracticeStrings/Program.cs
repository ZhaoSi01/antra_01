// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("aaaabbc");
revert("aaaabbc");
Console.WriteLine("Input your URL!");
String url = Console.ReadLine();
ParseUrl(url);



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

static void ParseUrl(String s)
{
    int check = s.IndexOf("://");
    //start = check + 3;
    int sps = 0;
    int end = s.Length - 1;
    int e = s.LastIndexOf('/');
    if(check + 2 != e)
    {
        end = e;
    }
    if (check + 3 < s.Length - 1)
    {
        Console.WriteLine(s.Substring(check + 3, end));
    }
    else
    {
        Console.WriteLine("Wrong input");
    }
    
    
}
