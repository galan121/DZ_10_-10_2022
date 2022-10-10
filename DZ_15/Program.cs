/* принимает на вход цифру, обозначающую день недели, и проверяет,
 является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите номер дня недели (от 1 до 7): ");
int n=Convert.ToInt32(Console.ReadLine());
while (n<1|n>7){
Console.Write("Вы ввели недопустимый номер дня недели, повторите ввод (от 1 до 7): ");
n=Convert.ToInt32(Console.ReadLine());
}
if (n==1) Console.WriteLine("Нет");
else if (n==2) Console.WriteLine("Нет");
else if (n==3) Console.WriteLine("Нет");
else if (n==4) Console.WriteLine("Нет");
else if (n==5) Console.WriteLine("Нет");
else if (n==6) Console.WriteLine("Да");
else if (n==7) Console.WriteLine("ДА");
else Console.WriteLine("Вы ввели недопустимый номер дня недели");

