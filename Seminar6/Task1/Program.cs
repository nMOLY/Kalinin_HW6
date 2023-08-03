// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountPositiveNumbers(int size)
{
    int count=0;
    for (int i = 0; i < size; i++)
    {
        int a = int.Parse(Console.ReadLine());
        if (a > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Сколько чисел ты хочешь ввести?");
int size = int.Parse(Console.ReadLine());
int numberOfPositiveValues = CountPositiveNumbers(size);
if (numberOfPositiveValues != 0) Console.WriteLine($"Количество чисел больше нуля равно {numberOfPositiveValues}");
else Console.WriteLine("Пользователь не ввел чисел больше нуля");
