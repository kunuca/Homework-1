// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите 3xзначное число");
int number=int.Parse(Console.ReadLine());
int x=number/100;
int y=number%10;

Console.WriteLine("Число без второй цифры "+x+""+y);