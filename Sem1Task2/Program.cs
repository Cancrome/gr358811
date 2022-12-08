//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

//Провряем, чтобы данные были не пустыми (null - пусто)
if(num1Line!=null&&num2Line!=null)
{

    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);

//Сравним числа
    if(num1>num2)
    {
        //Если 1>2, выводим 1 число
        Console.WriteLine(num1);
    }
    //Иначе
    else
    {
        //Выводим 2 число
        Console.WriteLine(num2);
    }
}