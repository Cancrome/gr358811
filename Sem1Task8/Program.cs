// Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Провряем, чтобы данные были не пустыми (null - пусто)
if(inputLine!=null)
{
 //Парсим введенное число
    int inputNumber = int.Parse(inputLine);
    
     //Остаток от деления 
    int lastDigit = inputNumber%2;

    // Стартовое число 2
    int startNumber = 2;

    //Выходное значение
    string outLine = string.Empty;

    // Если остаток 0, то... 
    if(lastDigit == 0)
    {
        // Пока стартовое число меньше введенного...
        while(startNumber<inputNumber)
        {
        
            outLine = outLine + startNumber + ", ";
            // стартовое число увеличиваем на 2 пока не дойдём до введенного
            startNumber=startNumber+2;
        }

        // Добавляем введенное
            outLine = outLine + inputNumber;

    }
// Иначе
    else

    {
        // Пока стартовое число меньше введенного...
        while(startNumber<inputNumber)
        {
            outLine = outLine + startNumber + ", ";
        
        // увеличиваем стартовое число на 2 до введенного
            startNumber=startNumber+2;
        }
    }
    
    //Выводим данные в консоль
    Console.WriteLine(outLine);
}