// Найти максимальное из трех чисел
int[] num={2,1,-7};
int max = num[0];
int count=0;
while (count<3) 
{
        if (max<num[count]) max=num[count];
        count++;
}
Console.WriteLine(max);