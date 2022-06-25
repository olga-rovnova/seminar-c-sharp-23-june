//Задача 41: Пользователь вводит с клавиатуры числа через запятую. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("введите целые числа через запятую без пробелов: ");
string numbers = $"{Console.ReadLine()} ";

int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == ',')
    {
        int j=i+1;
        if (numbers[j] !='0' && numbers[j] !='-')
        count++;
    }
} 

if (numbers[0] !='0' && numbers[0] !='-')
{
    count++;
}

Console.WriteLine($"Количество положительных чисел, введенных пользователем: {count}");
