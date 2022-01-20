// See https://aka.ms/new-console-template for more information
Console.Write("What is your percentage in the class? ");
string percent = Console.ReadLine();

int x = int.Parse(percent);


if (x >= 90)
{
    Console.WriteLine($"Your grade is an A");
    Console.Write("Congrats! You passed the class");
} 
else if (x >= 80 && x < 90)
{
    Console.WriteLine("Your grade is a B");
    Console.Write("Congrats! You passed the class");
}
else if (x >=70 && x < 80)
{
    Console.WriteLine("Your grade is a C");
    Console.Write("Congrats! You passed the class");
}
else if (x >=60 && x < 70)
{
    Console.WriteLine("Your grade is a D");
    Console.Write("Oh no! You didn't pass the class");
}
else if (x < 60)
{
    Console.WriteLine("Your grade is an F");
    Console.Write("Oh no! You didn't pass the class");
}


