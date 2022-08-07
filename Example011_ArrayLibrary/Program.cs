void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collect)
{
    int count = collect.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collect[position]);
        position++;
    }
}

int IndexOF(int[] collection, int find)
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

int[] array = new int[10]; // создай новый массив, в ктором будет 10 эллементов.

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOF(array, 7);
Console.WriteLine(pos);


