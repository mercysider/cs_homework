Console.Write("Введите первое число: ");
string userNum1 = Console.ReadLine();

Console.Write("Введите второе число: ");
string userNum2 = Console.ReadLine();

Console.Write("Введите третье число: ");
string userNum3 = Console.ReadLine();

int maxNum = 0;
int Num1 = Convert.ToInt32(userNum1);
int Num2 = Convert.ToInt32(userNum2);
int Num3 = Convert.ToInt32(userNum3);

if ((Num1 == Num2) && (Num1 == Num3))
{
Console.Write("Введены три одинаковых числа: ");
Console.Write(Num1);
}
else
{
    if (Num1 > Num2) maxNum = Num1;
    else maxNum = Num2;

    if (Num3 > maxNum) maxNum = Num3;
    
Console.Write("Большее из введенных чисел: " + maxNum);
}