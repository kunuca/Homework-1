// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите 3xзначное число");
int number=int.Parse(Console.ReadLine());
int x=number/10;
int y=x%10;

Console.WriteLine("Вторая цифра числа "+y);
