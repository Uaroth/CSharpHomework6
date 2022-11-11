// Велено делать в одном файле

// Первая задача. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Здравствуйте. Введите числа через пробел");

string userText = Console.ReadLine();
string[] userArray = userText.Split(" ");

CountPositives(userArray);

void CountPositives(string[] text)
{
    int size = userArray.Length;
    int[] numbersArray = new int[size];

    for (int i = 0; i < text.Length; i++)
    {
        numbersArray[i] = int.Parse(text[i]);
    }

    int count = 0;
    for (int j = 0; j < numbersArray.Length; j++)
    {
        if (numbersArray[j] > 0) count++;
    }
    Console.WriteLine($"Количество положительных = {count}");
}
