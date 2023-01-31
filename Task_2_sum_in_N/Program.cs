// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

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


int num = InputNumber("Введите число ");
string numString = Convert.ToString(num);
int index = 0;
int sum = 0;

while(index < numString.Length)
{
   sum = sum + Convert.ToInt32(Convert.ToString(numString[index]));
   index ++;
}

System.Console.WriteLine(sum);






  


