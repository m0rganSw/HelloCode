int[] array = {1, 2, 18, 4, 18, 6, 7, 18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // без break - выводит все позиции с числом 18, с break выводит первое искомое.
    }
    index++;
}