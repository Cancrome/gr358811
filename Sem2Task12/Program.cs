// Задача №12
// Напишите программу, которая будет
// принимать на вход два числа и выводить,
// является ли второе число кратным
// первому. Если второе число некратно
// первому, то программа выводит о статок
// от деления .

int number01 = int.Parse(Console.ReadLine()??"0");
int number02 = int.Parse(Console.ReadLine()??"0");

int result = number02%number01;

if (result==0)
{
    Console.WriteLine("Число " + number02 + " делится на число " + number01 + " без остатка");
}
else
{
    Console.WriteLine("Число " + number02 + "  не делится на число " + number01 + " без остатка, остаток равен " + result);
}