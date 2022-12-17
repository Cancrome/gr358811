// №10 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Провряем, чтобы данные были не пустыми (null - пусто)
if(inputLine!=null)
{
 //Парсим введенное число
    int inputNumber = int.Parse(inputLine);

 //Остаток от деления 
    int firstNumber = inputNumber/10;

    int secondNamber = firstNumber%10;

    Console.WriteLine(secondNamber);
}