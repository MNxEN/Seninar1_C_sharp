Console.Write("Enter number =>");                           //вывод приграшения на экран
string inputedString = Console.ReadLine();                   //ввод пользователя (строка)  
int number = Convert.ToInt32(inputedString);                   //Преобразование строки в число
Console.WriteLine($"You enter number: {number}!");          //Вывод введенного значения

int square = number*number;                                  //Расчет квадрата числа   
Console.WriteLine($"Square number {number} equals {square}");      //вывод результата