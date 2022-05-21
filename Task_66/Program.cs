// Задача 66: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//            числа в промежутке от M до N.
// Уточнение задания:
// 1. На печать выводятся числа между M и N, не включая границы диапазона.

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
    }
    return number;
}

int InputIntegerNumber(string text1, string text2, string text3)
{   string messegeForUser = string.Empty;
    messegeForUser = $"Введите {text1} {text2} {text3}: ";
    int result = CheckNaturalNumbers(messegeForUser); 
    return result; 
}

void PrintNaturalNumbersRange(int m, int n, int sign)
{   if(m == n) {Console.WriteLine($"{n}."); return;} 
    else {Console.Write($"{m}, "); PrintNaturalNumbersRange(m + sign, n, sign);}
}



int M, N;
string text1 = string.Empty, text2 = string.Empty, text3 = string.Empty;
text1 = "натуральное"; text2 = "число"; text3 = "m";
M = InputIntegerNumber(text1, text2, text3);
text3 = "n";
N = InputIntegerNumber(text1, text2, text3);
int sign, m, n;
if(M > N) {sign = -1; m = M - 1; n = N + 1;}
else {sign = 1;  m = M + 1; n = N - 1;}
Console.WriteLine($"Натуральные числа из диапазона от {M} до {N}:");
PrintNaturalNumbersRange(m, n, sign);
