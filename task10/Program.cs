int number = new Random().Next(100,1000);
int secondDigit;
string answer;

secondDigit = (number / 10) % 10;
answer = "Вторая цифра в числе " + number + ": " + secondDigit;

Console.WriteLine(answer);