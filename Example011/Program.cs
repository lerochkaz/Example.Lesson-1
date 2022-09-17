Console.Clear();
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);
int pos = IndexOf(array, 4);
Console.WriteLine(pos);

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //Если элемента с таким значением нет, то тогда выводится 0. Но программисты договорились обозначать и выводить -1. Поэтому здесь стоит чисто -1 вместо 0.

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;

    }
    return position;
}