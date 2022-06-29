// See https://aka.ms/new-console-template for more information


int max = 100;
for (byte i = 0; i < max; i++)
{
    Console.WriteLine("Hello, World! {0}",i);
}


int correct = new Random().Next(3) + 1;
Console.WriteLine("Please input your guess");

int guess = int.Parse(Console.ReadLine());
if(guess >= 1 && guess <= 3)
{
    if(guess == correct)
    {
        Console.WriteLine("Correct !! ");
    }else if (guess > correct)
    {
        Console.WriteLine("The guess is high");
    }
    else
    {
        Console.WriteLine("The guess is low");
    }
}
else
{
    Console.WriteLine("Out of Range");
}

Console.WriteLine("Correct is {0}", correct);
pyramid(5);


static void pyramid(int line)
{
    Console.WriteLine("fffff");
    for(int i = 0; i < line; i++)
    {
        while (i < (line * 2 - 1))
        {
            Console.Write(' ');
        }
        while(i < (2 * i - 1))
        {
            Console.Write("*");
        }
        
        while (i < (line * 2 - 1))
        {
            Console.Write(' ');
        }
        Console.WriteLine(" ");
    }
}


