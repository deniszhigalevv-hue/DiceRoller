Random dice = new Random();
int diceNumber = 0;

Console.WriteLine("Сколько кубиков бросить?");
List<int> rolls = new List<int>();
while (true)
{
    var userInput = Console.ReadLine();
    if (int.TryParse(userInput, out diceNumber))
    {
        if (diceNumber > 0 && diceNumber <= 100)
        {
            Console.WriteLine("Ok");
            break;
        }
        else
        {
            Console.WriteLine("Dice number must be 1-100");
        }
    }
    else
    {
        Console.WriteLine("Input a number");
    }
}
for (int i = 0; i < diceNumber; i++)
{
    int roll = dice.Next(1, 7);
    rolls.Add(roll);
}
int total = rolls.Sum();
Console.WriteLine($"You got: {string.Join(", ", rolls)}");
Console.WriteLine($"Total: {total}");
if (total == 69)
{
    Console.WriteLine("Hehe nice");
}
