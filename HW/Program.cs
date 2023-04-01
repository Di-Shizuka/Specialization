
void NewArray(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
}

void PrintArray(string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
}

string[] array1 = new string[4] { "Hello", "2", "world", ":-)" };
string[] array2 = new string[array1.Length];
NewArray(array1, array2);
PrintArray(array2);