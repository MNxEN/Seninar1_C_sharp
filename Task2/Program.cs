string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.Write("Введите номер дня недели: ");
string weekday = Console.ReadLine();
int dayNumber = Convert.ToInt32(weekday);
if (dayNumber < 0 || dayNumber > 6)
{
    Console.WriteLine("Нет такого дня недели!");
}
else
{
    Console.WriteLine(week[dayNumber - 1]);
}



