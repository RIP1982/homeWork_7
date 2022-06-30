// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");
int[,] numbers = new int[m,n];


for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i,j] = new Random().Next(-100, 100);
    }
}

PrintArray(numbers);

int num = Input("Введите позицию элемента: ");
int countPosition = 0;

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        countPosition++;
        if(num == countPosition)
        {
            Console.WriteLine($"{countPosition} : {numbers[i,j]}");
        }
        
    }
}

if(num < 1 || num > countPosition)
{
    Console.WriteLine("Такого элемента нет!");
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}