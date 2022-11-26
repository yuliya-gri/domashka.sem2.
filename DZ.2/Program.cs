//Наптшите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нетю

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
while  (num >=1000) num = num / 10;

    
    Console.WriteLine("Третья цифра");
    Console.WriteLine(num%10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
