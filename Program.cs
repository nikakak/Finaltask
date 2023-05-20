string[] num = new string[3] {"true", "false", "notgiven" };
string[] mas = new string[num.Length];
void MainArray(string[] num, string[] mas)
{
    int count = 0; 
    for(int i = 0; i<num.Length; i++)
    {
        if(num[i].Length<=2)
        {
            mas[count] = num[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
MainArray(num, mas);
PrintArray(mas);
