/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int randomNum(int min, int max)
{
    int num = new Random().Next(min, max);
    return num;
}

void PrintArray(int[] collection)
{
    Console.Write($"Ваш массив -> [");
    for (int index = 0; index < collection.Length-1; index++)
    {
        Console.Write($"{collection[index]},");
    }
    Console.Write($"{collection[collection.Length-1]}");
    Console.WriteLine("]");
}

int findCountEvenNumbers(int[] incomingArray)
{
    int count = 0;
        Console.Write("Чётные числа из массива -> ");
    for (int index = 0; index < incomingArray.Length; index++)
    {
        if (incomingArray[index] % 2 == 0)
        {
            Console.Write($"{incomingArray[index]}({index+1}) ");
            count++;
        }
    }
    Console.WriteLine("");
    Console.WriteLine($"Количество чётных чисел в массиве -> {count}");
    return count;
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа покажет количество чётных чисел в случайном массиве с положительными трёхзначными числами");
Console.WriteLine("(В скобках справа от найденного числа показано место в массиве по счету слева направо для легкого нахождения и сравнения. Не индекс!)");

string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    int[] arr = new int[randomNum(1, 10)];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomNum(100, 999);
    }
    PrintArray(arr);
    findCountEvenNumbers(arr);

    Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");