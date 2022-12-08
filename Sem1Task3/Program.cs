//Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Провряем, чтобы данные были не пустыми (null - пусто)
if(inputLine!=null)
{

    //Создаем массив с данными
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресенье";

    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    //Находим название дня недели по введенному номеру
    string outDayOfWeek = dayOfWeek[inputNumber-1];

    //Выводим данные в консоль
    Console.WriteLine(outDayOfWeek);
}