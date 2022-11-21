// Напишите программу, которая задает массив из 8 элементов и выводит их на экран
int SIZE = 8;
int [] Array = new int [SIZE];
Random rnd = new Random();
for (int i = 0; i < SIZE; i++)
{
    Array [i] = rnd.Next(8);
    Console.Write($"{Array[i]},");
}