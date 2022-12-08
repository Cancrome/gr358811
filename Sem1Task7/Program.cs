// Задача №7
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа.

// Ввели число в строковом виде
string? inputLine = Console.ReadLine();

if (inputLine!=null)
{
    // Сделали число десятичным в виде
    int inputNumber = int.Parse(inputLine);

    //Остаток от деления 
    int lastDigit = inputNumber%10;
    
    // Выводим сообщение
    Console.WriteLine(lastDigit);

}