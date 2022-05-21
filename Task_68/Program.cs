// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//            Даны два неотрицательных числа m и n.

void TitleInputErrorMessage() 
{
    Console.WriteLine("Уважаемый пользователь, вы ошиблись при вводе! ");
}

void NumberInputErrorMessage (string userNumber, string definitionNumber) 
{
    TitleInputErrorMessage();
    Console.Write($"Введённое Вами значение: {userNumber},");
    Console.WriteLine($" не является {definitionNumber} числом.");
}

int CheckIntegerPositiveNumbers (string messageForUser) 
{
    int number = 0, i = 0;
    string userNumber = string.Empty;
    string definitionNumber = "натуральным";
    bool success = false;
    while(i == 0) 
    {
        Console.Write(messageForUser);
        userNumber = Console.ReadLine();
        success = int.TryParse(userNumber, out number);
        if(success) 
        {
            number = int.Parse(userNumber);
            if(number >= 0) i = 1;
            else NumberInputErrorMessage(userNumber, definitionNumber); 
        }
        else 
        {
            NumberInputErrorMessage(userNumber, definitionNumber);
        } 
    }
    return number;
}

int InputIntegerPositiveNumber(string text1, string text2, string text3) 
{
    string messegeForUser = string.Empty;
    messegeForUser = $"Введите {text1} {text2} {text3}: ";
    int result = CheckIntegerPositiveNumbers(messegeForUser); 
    return result; 
}

int AckermanFunc(int m, int n) 
{
    if(m == 0) return n + 1;
    if(n == 0) return AckermanFunc(m - 1, 1); 
    return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
}

Console.WriteLine("Вычисление функции Аккермана.");
int m, n;
string text1 = string.Empty, text2 = string.Empty, text3 = string.Empty;
text1 = "целое положительное"; text2 = "число"; text3 = "m";
m = InputIntegerPositiveNumber(text1, text2, text3);
text3 = "n";
n = InputIntegerPositiveNumber(text1, text2, text3);
Console.WriteLine($"Значение функции Аккермана: A({m}, {n}): {AckermanFunc(m, n)}.");
