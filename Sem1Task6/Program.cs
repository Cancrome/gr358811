// №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число
// чётным (делится ли оно на два без остатка).

// Ввели число в строковом виде
string? inputLine = Console.ReadLine();

if (inputLine!=null)
{
    // Сделали число десятичным в виде
    int inputNumber = int.Parse(inputLine);

    //Остаток от деления 
    int lastDigit = inputNumber%2;

        if(lastDigit == 0)
        {

            Console.WriteLine("Число четное");
        }

        else
        {

            Console.WriteLine("Число не четное");
        }

}