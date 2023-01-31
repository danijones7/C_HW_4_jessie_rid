// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено некорректное число");
    }
    return number;
}

double Exponent(int num1, int num2)
{
    
int result = 1;
{
    for (int i = 1; i <= num2; i++)
        result = num1 * num1;
    return result;
}
}


int A = InputNumber("Введите число А: ");
int B = InputNumber("Введите число B: ");

// double answer = Math.Pow(A, B);
// System.Console.WriteLine(answer);

double answer = Exponent(A, B);

// System.Console.WriteLine(answer);

System.Console.WriteLine($"A в степени B =  {answer}");
