//
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

//Провряем, чтобы данные были не пустыми (null - пусто)
if(num1Line!=null&&num2Line!=null)
{

    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    
    if(num2*num2==num1)
    {
        Console.WriteLine("Первое число квадрат второго!");
    }
    else
    {
        Console.WriteLine("Первое число не квадрат второго");
    }
}