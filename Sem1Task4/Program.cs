//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

//Провряем, чтобы данные были не пустыми (null - пусто)
if(num1Line!=null&&num2Line!=null&&num3Line!=null)
{

    //Парсим введенные числа
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);

//Сравним 1 и 2 число
    if(num1>num2)
    {
        //Если 1>2, выводим 1 число
        Console.WriteLine(num1);
    }
    //Иначе
    else
    {
        //Сравниваем 2 и 3 число
        if(num2>num3)
        {
        //Если 2>3, выводим 2 число
          Console.WriteLine(num2);  
        }
        else
        {

           //Выводим 3 число
            Console.WriteLine(num3); 
        }
    }

}
