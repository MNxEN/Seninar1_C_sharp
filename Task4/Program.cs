Console.Write("Введите число: ");
string strNumber = Console.ReadLine();
int number1 = Convert.ToInt32(strNumber);
int number2 = -number1;
string result="";
while(number2 <= number1)
{
    //Console.Write($"{number2} ");
    result = ($"{result} {number2}");
    number2++;
};
Console.WriteLine(result);