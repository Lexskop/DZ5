/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int findSumOddIndex(int[] incomingArray)
{
    int count = 0;
    Console.Write("Полученные числа на нечётных позициях массива -> ");
    for (int index = 1; index < incomingArray.Length; index+=2)
    {
        count = count + incomingArray[index];
        Console.Write($"{incomingArray[index]}({index+1}) ");
    }
    Console.WriteLine("");
    Console.WriteLine($"Сумма всех чисел массива на нечётных позициях -> {count}");
    return count;
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа задаёт массив, заполненный случайными числами и находит сумму элементов, стоящих на нечётных позициях.");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    int[] arr = new int[randomNum(1, 10)];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomNum(-99, 99);
    }
    PrintArray(arr);
    findSumOddIndex(arr);

    Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");