// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//            Даны два неотрицательных числа m и n.

void TitleInputErrorMessage()
{   Console.WriteLine("Уважаемый пользователь, вы ошиблись при вводе! ");
}

void NumberInputErrorMessage (string userNumber, string definitionNumber)
{   TitleInputErrorMessage();
    Console.Write($"Введённое Вами значение: {userNumber},");
    Console.WriteLine($" не является {definitionNumber} числом.");
}

int CheckNaturalNumbers (string messageForUser)
{   int number = 0, i = 0;
    string userNumber = string.Empty;
    string definitionNumber = "натуральным";
    bool success = false;
    while(i == 0) 
    {   Console.Write(messageForUser);
        userNumber = Console.ReadLine();
        success = int.TryParse(userNumber, out number);
        if(success)
        {   number = int.Parse(userNumber);
            if(number > 0) i = 1;
            else NumberInputErrorMessage(userNumber, definitionNumber); 
        }
        else 
        {   NumberInputErrorMessage(userNumber, definitionNumber);
        } 
        Console.WriteLine();
    }
    return number;
}

int InputIntegerNumber(string text1, string text2, string text3)
{   string messegeForUser = string.Empty;
    messegeForUser = $"Введите {text1} {text2} {text3}: ";
    int result = CheckNaturalNumbers(messegeForUser); 
    return result; 
}

int AckermanRec(int m, int n)
{   int a = 0;
    if(m == 0) return a + n + 1;
    else if(m != 0 && n == 0) return a + AckermanRec(m - 1, n);
        else if(m != 0 && n != 0) return AckermanRec(m - 1, AckermanRec(m, n - 1));
            else return AckermanRec(m, n);
    }

Console.WriteLine("Программа вычисления функции Аккермана: A(m, n).");
int m, n;
string text1 = string.Empty, text2 = string.Empty, text3 = string.Empty;
text1 = "натуральное"; text2 = "число"; text3 = "m";
m = InputIntegerNumber(text1, text2, text3);
text3 = "n";
n = InputIntegerNumber(text1, text2, text3);
Console.WriteLine($"Значение функции Аккермана: A({m}, {n}): {AckermanRec(m, n)}.");
