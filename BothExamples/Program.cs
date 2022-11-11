// Велено делать обе задачи в одном файле

// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.WriteLine("Здравствуйте. Введите числа через пробел");

// string userText = Console.ReadLine();
// string[] userArray = userText.Split(" ");

// CountPositives(userArray);

// void CountPositives(string[] text)
// {
//     int size = text.Length;
//     int[] numbersArray = new int[size];

//     for (int i = 0; i < text.Length; i++)
//     {
//         numbersArray[i] = int.Parse(text[i]);
//     }

//     int count = 0;
//     for (int j = 0; j < numbersArray.Length; j++)
//     {
//         if (numbersArray[j] > 0) count++;
//     }
//     Console.WriteLine($"Количество положительных = {count}");
// }

// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем

// Интернет напоминает - пересекутся там, где их уравнения равны.
// k1 * x + b1 = k2 * x + b2
// x(k1-k2) = b2 - b1
// x = (b2-b1)/(k1+k2)

Console.WriteLine("Здравствуйте. Введите b1, k1, b2 и k2 через пробел");

string userText = Console.ReadLine();
string[] userArray = userText.Split(" ");
double [] userNumbers = ReadNumbers (userArray);

double b1 = userNumbers[0];
double k1 = userNumbers[1];
double b2 = userNumbers[2];
double k2 = userNumbers[3];

double x = (b2-b1)/(k1-k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения имеет координаты ({x},{y})");

double[] ReadNumbers(string[] text)
{
    int size = text.Length;
    double[] numbersArray = new double[size];

    for (int i = 0; i < text.Length; i++)
    {
        numbersArray[i] = double.Parse(text[i]);
    }
    return numbersArray;
}