// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine("ВВедите число: ");
int number =  Convert.ToInt32(System.Console.ReadLine());
int sum = 0;
while (number != 0)
{
    sum += number % 10;
    number = number / 10; 
}
System.Console.WriteLine(sum);
