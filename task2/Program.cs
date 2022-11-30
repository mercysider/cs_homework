Console.Write("Введите первое число: ");
string userNum1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string userNum2 = Console.ReadLine();

int maxNum = 0;
int Num1 = int.Parse(userNum1);
int Num2 = int.Parse(userNum2);

if (Num1 == Num2)
{
Console.Write("Введены два одинаковых числа: ");
Console.Write(Num1);
}
else
{
    if (Num1 > Num2) maxNum = Num1;
    else maxNum = Num2;
Console.Write("Большее из введенных чисел: ");
Console.Write(maxNum);
}