//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using static Library36;
using static System.Console;
{
    int[] ar = CreateArray(4);
    Fill(ar);
    Console.WriteLine(Print(ar));
    int result = 0;

for (int i = 0; i < ar.Length; i++)
{
    if (ar[i] % 2 == 0)
    result = result + 1;
}
     Console.WriteLine(result);
}

