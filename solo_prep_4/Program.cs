// See https://aka.ms/new-console-template for more information

List<float> numbers = new List<float>();

float NumChoice = -1;

while (NumChoice != 0)
{
    Console.WriteLine("What number would you like to add? ");
    NumChoice = float.Parse(Console.ReadLine());

    if (NumChoice != 0)
    {
        numbers.Add(NumChoice);
    }

}


Console.WriteLine("Your list is: ");
foreach (float number in numbers)
{
   
   Console.WriteLine(number);
}

float NumbersSum = numbers.Sum();
Console.WriteLine($"The sum of the your list: {NumbersSum}");

float NumbersAvg = NumbersSum/numbers.Count();
Console.WriteLine($"The average of the list is: {Math.Round(NumbersAvg, 2)}");

float BigNum = -1;

foreach (float number in numbers)
{
    if (number > BigNum)
    {
        BigNum = number;
    }
}
Console.WriteLine($"The biggest number in your list is: {BigNum}");