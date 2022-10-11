/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение 
чисел от 1 до N. 4 -> 24  5 -> 120 */


int num = int.Parse(Console.ReadLine());
  int result = addition(num);  
  Console.WriteLine(result);  
  int addition(int number)
   {     
    int count = 1;        
    for (int i = 1; i <= number; i++)  
 {         
    count *= i;    
 }      
    return count;
 }
