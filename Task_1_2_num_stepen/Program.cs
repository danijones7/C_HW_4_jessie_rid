// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int InputNumber(string str)
{
    int number;
    string text;
    while(true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();

        if(int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено некорректное число");
    }
return number;
}

int A = InputNumber("Введите число А: ");
int B = InputNumber("Введите число B: ");

double answer = Math.Pow(A, B);
System.Console.WriteLine(answer);


