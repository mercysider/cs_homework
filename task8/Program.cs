Console.Write("Введите число: ");
string userNum = Console.ReadLine();
int IntNum = Convert.ToInt32(userNum); 
int i = 1; //счетчик

if (IntNum <= 1) 
{
Console.Write("Нет четных чисел от 1 до ");
Console.Write(IntNum);
}
else 
{
if (IntNum %2 != 0) IntNum = IntNum - 1; 

    while (i < IntNum/2)
    {
        Console.Write(i*2 + ", ");
        i++;
    }
    Console.Write(IntNum);
}