// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите число дня недели");
int day=int.Parse(Console.ReadLine());
string[] week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.WriteLine(week[day-1]);