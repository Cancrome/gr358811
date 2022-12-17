// №13 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Провряем, чтобы данные были не пустыми (null - пусто)
if(inputLine!=null)
{
    // парсим данные
    int number = int.Parse(inputLine);

    // делим число до 3его
    int newNumber = number/100;

    //парсим обратно 
    string stringNumber = number.ToString();

    // если число без целого => 3его числа нет
    if(newNumber==0)
    {
        
        Console.WriteLine("третьей цифры нет");
    }
    
    // Иначе
    else
    {

    //Переворачиваем строку
    char[] inputarray = stringNumber.ToCharArray();
    Array.Reverse(inputarray);
    string outputLine = new string(inputarray);

    // парсим
    int output = int.Parse(outputLine);

    //Получаем первое и второе число по отдельности

    int firstNumber = output%1000;// 72433:1000 = 72,433 (убирает "72,", остается 433) !При условии, что в начале int
 
    int secondNumber = firstNumber/100; // 433:100 = 4,33 (убирает ",33", остается 4) 

         Console.WriteLine(secondNumber);
            

    }
}
