/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int findNumberArray(int[] incomingArray)
{
    int res = 0;
    for (int index = 0; index <= (incomingArray.Length - 1) / 2; index++)
    {
        if (index < (incomingArray.Length - 1) / 2 || incomingArray.Length % 2 == 0)
        {
        res = incomingArray[index] * incomingArray[(incomingArray.Length - 1) - index];
        Console.Write($"{res} ");
        }
        else if (index == (incomingArray.Length - 1) / 2 || incomingArray.Length % 2 == 1)
        {
            res = incomingArray[index];
            Console.Write($"{res}");
        }
    }
    return res;
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа находит произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    int[] arr = new int[randomNum(1, 10)];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomNum(1, 10);
    }
    PrintArray(arr);
    findNumberArray(arr);
    Console.WriteLine("");

    Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");