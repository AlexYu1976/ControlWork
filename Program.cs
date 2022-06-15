Console.WriteLine("Введите количество слов в массиве ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];

for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToDouble(Console.ReadLine());
}


string[] startarray = new string[] { "Home", "Add", "Brase", "Cap", "On" };
string[] finisharray = new string[startarray.Length];
void SelectArray(string[] startarray, string[] finisharray)
{
    int count = 0;
    for (int i = 0; i < startarray.Length; i++)
    {
        if (startarray[i].Length <= 3)
        {
            finisharray[count] = startarray[i];
            count++;
        }
        
    }

}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SelectArray(startarray, finisharray);
PrintArray(finisharray);
