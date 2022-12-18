using static System.Console;

Write("Введите индекс массива для поиска: ");
int find = Convert.ToInt32(ReadLine()!);

int[] array = { 8, 23, 5, 1, 2, 3, 4 }; // length = 7

int n = array.Length;

int index = 0;

while (index < n)
{
    if(index == find)
    {
        WriteLine("Под индексом массива: " + find + ", находится число: " + array[index]);
    }
        
    index ++;
}
