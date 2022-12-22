// №19 Напишите программу, которая принимает на вход 
// пятизначное число и проверяет,
// является ли оно палиндромом.


int number0 = ReadData("Введите число: ");

PrintQuterTest();

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


// Метод определяет является ли число палиндромом
void PrintQuterTest()
{
    string stringNumber0 = number0.ToString();

    //Переворачиваем строку
    char[] inputarray = stringNumber0.ToCharArray();
    Array.Reverse(inputarray);
    string stringNumber1 = new string(inputarray);

    // парсим
    int number1 = int.Parse(stringNumber1);

    //Сравниваем числа 
    if (number0==number1) Console.WriteLine("Число " + number0 +" является полиндромом");
    if (number0!=number1) Console.WriteLine("Число " + number0 +" не является полиндромом");
  
}

