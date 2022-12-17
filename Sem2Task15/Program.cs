// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Провряем, чтобы данные были не пустыми (null - пусто)
if(inputLine!=null)
{

    //Создаем массив с данными
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Нет";
    dayOfWeek[1] = "Нет";
    dayOfWeek[2] = "Нет";
    dayOfWeek[3] = "Нет";
    dayOfWeek[4] = "Нет";
    dayOfWeek[5] = "Да";
    dayOfWeek[6] = "Да";

    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    //Находим название дня недели по введенному номеру
    string outDayOfWeek = dayOfWeek[inputNumber-1];

    //Выводим данные в консоль
    Console.WriteLine(outDayOfWeek);
}