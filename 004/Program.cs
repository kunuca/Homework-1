//Выяснить является ли число чётным
Console.WriteLine("Введите число");
int num=int.Parse(Console.ReadLine());
int a=num%2;
if (a==0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");