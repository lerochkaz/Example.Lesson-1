Console.Clear();
Console.WriteLine("Введите пять чисел: ");
int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int a3 = int.Parse(Console.ReadLine());
int a4 = int.Parse(Console.ReadLine());
int a5 = int.Parse(Console.ReadLine());
int[] array = { a1, a2, a3, a4, a5 };
Console.WriteLine("Введите число, которое необходимо найти: ");
int find = int.Parse(Console.ReadLine());
int n = array.Length;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Индекс числа, которого мы ищем {index}");
        break;
    }
    index++;
}