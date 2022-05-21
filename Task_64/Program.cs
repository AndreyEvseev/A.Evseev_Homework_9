// Задача 64: Напишите программу, которая будет принимать на вход число и возвращать 
//            сумму его цифр.

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

int InputIntegerNumber(string text1, string text2)
{   string messegeForUser = string.Empty;
    messegeForUser = $"Введите {text1} {text2}: ";
    int result = CheckNaturalNumbers(messegeForUser); 
    return result; 
}

int SumDigitsNumberRec(int num)
{   if(num == 0) return 0;
    else return SumDigitsNumberRec(num / 10) + num % 10;
}

int num;
string text1 = string.Empty, text2 = string.Empty;
text1 = "натуральное"; text2 = "число";
num = InputIntegerNumber(text1, text2);
Console.WriteLine(SumDigitsNumberRec(num));
