

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
