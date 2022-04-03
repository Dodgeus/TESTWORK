string[] arr = { "hello", "2", "world", ":-)" };
int length = 0;
int CountArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) length++;
    }
    return length;

}
void EditNewArray(string[] array, string [] massive)
{   
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i].Length <= 3)
        {
            massive[j] = array[i];
            j++;
        }
    }
}
void WriteArray(string[] a)
{
    for (int l = 0; l< a.Length; l++)
    {
        Console.Write($"{a[l]}; ");
    }
}
CountArray(arr);
if (length == 0) Console.WriteLine("В этом массиве нет элементов, у которых символов кол-во сиволов меньше или равно 3");
string [] massive = new string[length];
EditNewArray(arr, massive);
WriteArray(massive);