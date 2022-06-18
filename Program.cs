Console.WriteLine("Введите количество элемнтов в массиве :\t  ");
int length = Convert.ToInt32(Console.ReadLine());
string [] StartArray = new string[length];


for (int i = 0; i < length; i++)
{
    Console.WriteLine($"\nВведите {i} элемент массива :\t");
    StartArray[i] = Console.ReadLine();
}


string[] FinishArray = new string[StartArray.Length];

void PrintArray(string[] StartArray)
{
    for (int i = 0; i < StartArray.Length; i++)
    {
        Console.Write($"{StartArray[i]} ");
    }
    Console.WriteLine();
}

PrintArray(StartArray);

void CountingArray(string[] StartArray, string[] FinishArray)
{
    int count = 0;
    for (int i = 0; i < StartArray.Length; i++)
    {
        if (StartArray[i].Length <= 3)
        {
            FinishArray[count] = StartArray[i];
            count++;
        }
        
    }

}

CountingArray(StartArray, FinishArray);
PrintArray(FinishArray);