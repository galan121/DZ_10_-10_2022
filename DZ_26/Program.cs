/*Задача 26: Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе. 456 -> 3 78 -> 2 89126 -> 5  */
int a = Convert.ToInt32(Console.ReadLine());
 int len = 0; if (a == 0)
{    
     len = 1;
} else 
{     
while(a != 0)    
{ 
    a /= 10;         
    len += 1;     
}
 }  Console.WriteLine(len);
 

