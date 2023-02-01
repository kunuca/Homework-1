// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите 3xзначное число");
int number=int.Parse(Console.ReadLine());
int x=number%10;
Console.WriteLine("Третья цифра числа "+x);