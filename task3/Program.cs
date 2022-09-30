/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int randomLength(int minLength, int maxLength)
{
    int num = new Random().Next(minLength, maxLength);
    return num;
}

double randomNum(int min, int max)
{
    int num1 = new Random().Next(min, max);
    double num2 = new Random().NextDouble();
    double sum = num1 + num2;
    return sum;
}

void PrintArray(double[] collection)
{
    Console.Write($"Ваш массив -> [");
    for (int index = 0; index < collection.Length-1; index++)
    {
        Console.Write($"{collection[index]:N2}; ");
    }
    Console.Write($"{collection[collection.Length-1]:N2}");
    Console.WriteLine("]");
}

double findSubtractMaxMin(double[] incomingArray)
{
    double calc = 0;
    double max = incomingArray[0];
    double min = incomingArray[0];
    int indexMax = 0;
    int indexMin = 0;
    for (int index = 0; index < incomingArray.Length; index++)
    {
        if (max < incomingArray[index])
        {
            max = incomingArray[index];
            indexMax = index;
        }
        if (min > incomingArray[index])
        {
            min = incomingArray[index];
            indexMin = index;
        }
        calc = max - min;
    }
    Console.WriteLine($"Max значение в массиве -> {max:N2}({indexMax+1})");
    Console.WriteLine($"Min значение в массиве -> {min:N2}({indexMin+1})");
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {calc:N2}");
    return calc;
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа находит произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    double[] arr = new double[randomLength(1,10)];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomNum(1, 10);
    }
    PrintArray(arr);
    findSubtractMaxMin(arr);

    Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");