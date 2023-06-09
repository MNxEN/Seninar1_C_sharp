Console.Write("Введите число №1: ");     //Приглашение ввода 
string firstStr = Console.ReadLine();
Console.Write("Введите число №2: ");
string secondStr = Console.ReadLine();

int firstNumber = Convert.ToInt32(firstStr);
int secondNumber = Convert.ToInt32(secondStr);

int square = firstNumber * firstNumber;

if (secondNumber == square) 
    {
        Console.WriteLine($"Второе число ({secondStr}) является квадратом первого числа ({firstStr})");
    }
else
    {
        Console.WriteLine($"Второе число ({secondStr}) не является квадратом первого числа ({firstStr})");
    }