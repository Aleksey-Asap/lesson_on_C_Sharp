int[] array = { 1, 12, 31, 4, 18, 19, 16, 19, 17 };

int n = array.Length;
int find = 19;

int index = 0;

while (index < n)
{
    if (array[index] == find) // равен элементу find
    {
        Console.WriteLine(index);
        break; // если 2 числа одинаковых
    }
    //index = index + 1;
    index++;
}