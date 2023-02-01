// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число от 10 до 99");
int number=int.Parse(Console.ReadLine());
int x=number/10;
int y=number%10;
if (x>y) Console.WriteLine("Наибольшая цифра числа "+number + " - "+x);
else Console.WriteLine("Наибольшая цифра числа "+number + " - "+y);