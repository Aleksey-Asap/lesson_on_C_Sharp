void FillArray(int[] collection) // даем наименование методу collection - наименование
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // новое случайно целое  число
        //index = index + 1;
        index++;
    }
}
// void - это метод ничего не возвращает (return)
void PrintArray(int[] col) // Метод void который будет печатать массив, col - новый аргумент
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // new .. Создай новый массив в котором будет 10 эллементов

FillArray(array); // Передадим наименование нашего массива
array[4] = 4;
array[6] = 4;

PrintArray(array); // Печатаем наш масиив
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);



