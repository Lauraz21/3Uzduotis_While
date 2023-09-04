//3.0 -
//3.1

Console.WriteLine("Iveskite skaiciu, kuri norite pakelti n-tuoju laipsniu: ");
float userInput = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Iveskite kuriuo laipsniu pakelti: ");
int power = Convert.ToInt32(Console.ReadLine());
int i = 1;
float sum = userInput;

while (i < power)
{
    sum = sum * userInput;
    i++;
}
Console.WriteLine(sum);




//3.2

Console.WriteLine("Iveskite skaiciu: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Parasykite grupiu kieki: ");
int groupAmount = Convert.ToInt32(Console.ReadLine());

int currentGroup = 1;

while (currentGroup <= groupAmount)
{
    int currentNumber = 1;
    Console.Write("->");

    while (currentNumber <= currentGroup)
    {
        Console.Write(number);
        currentNumber++;
    }
    currentGroup++;
}