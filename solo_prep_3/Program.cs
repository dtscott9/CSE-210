// See https://aka.ms/new-console-template for more information
Random RandNum = new Random();
int number = RandNum.Next(1, 11);




int numGuess = 0;

while (numGuess != number)
{
Console.WriteLine("Guess the number? ");
numGuess = int.Parse(Console.ReadLine());
if (numGuess > number)
{
    Console.WriteLine("Lower");
}
else if (numGuess < number)
{
    Console.WriteLine("Higher");
}
else 
{
    Console.WriteLine("Congrats! You guessed it");
 
}
}






