
void СhoiceArray(string[] array, string[] secondArray)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            secondArray[i] = array[i];
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == string.Empty) i++;
        else Console.Write($"{array[i]} ");
    }
}
Console.Clear();
string[] array = { "hello", "2", "world", ":-)" };
string[] newarray = new string[array.Length];
СhoiceArray(array, newarray);
PrintArray(newarray);
