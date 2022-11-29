
//Написать программу,которая принимает на вход цифру
// обозначающую день недели и проверяет, является ли этот
//день выходным
int num = new Random().Next(1,8);
Console.WriteLine("Сгенерированное случайное число");
Console.WriteLine(num);
int num1 = 7;

int num2 = 6;

if(num == num1)
{
    Console.WriteLine("Число соответствует выходному дню недели");
}
else 
if(num == num2)
{
    Console.WriteLine("Число соответствует выходному дню недели");
}

else
{
    Console.WriteLine("Число не соответствует выходному дню недели");
}