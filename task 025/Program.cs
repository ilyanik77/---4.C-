//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void PowNumber (int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    
    }
    Console.WriteLine(result);
}
PowNumber(2, 4);










