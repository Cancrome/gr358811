//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Провряем, чтобы данные были не пустыми (null - пусто)
if(inputLine!=null)
{
    //Парсим введенное число
    int inputNamber = int.Parse(inputLine);
    
    //Находим квадрат числа
    int outNumber = inputNamber*inputNamber;
    //int outNumber = (int)Math.Pow(inputNumber,2);

    //Выводим данные в консоль
    Console.WriteLine(outNumber); 
    //Console.WriteLine(Math.Pow(int.Parse(inputLine),2))
}

