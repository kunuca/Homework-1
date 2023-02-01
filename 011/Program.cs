// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int number=int.Parse(Console.ReadLine());

if (number>99)
{int x=number/100;
int y=x%10;
Console.WriteLine("Третья цифра числа "+y);}
else Console.WriteLine("Третьей цифры нет");