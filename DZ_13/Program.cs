/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите трёхзначное число N:  ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<100|n>999)
{
Console.WriteLine("Вы ввели недопустимое число, повторите ввод: ");
 n = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Последняя цифра числа: " + Convert.ToString(n%10));
