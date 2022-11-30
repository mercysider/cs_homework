Console.Write("Введите число: ");
string userNum = Console.ReadLine();

int IntNum = Convert.ToInt32(userNum); 

if (IntNum %2 == 0) Console.Write("Введено четное число");
else Console.Write("Введено нечетное число");