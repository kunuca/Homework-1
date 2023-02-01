//По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите 1-е число");
int number1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int number2=int.Parse(Console.ReadLine());
double s=Math.Sqrt(number1);
if (s ==number2 ) Console.WriteLine("Является");
else Console.WriteLine("Не является");