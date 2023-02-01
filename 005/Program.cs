// Показать четные числа от 1 до N
Console.WriteLine("Введите число");
int number=int.Parse(Console.ReadLine());
int count=1;
int x=0;
while (count < number) 
 {x=count%2;
    if (x==0) Console.Write(count+" ");
    count++;
 }
x=number%2;
if (x==0) Console.Write(number);