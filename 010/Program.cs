// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите 1-е число ");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-е число ");
int num2=int.Parse(Console.ReadLine());
if (num1>num2)
{
int x=num1%num2;
    if (x==0) Console.WriteLine("Число "+num1+" кратно числу "+num2);
    else Console.WriteLine("Остаток "+x);}
else Console.WriteLine("Второе число больше первого");