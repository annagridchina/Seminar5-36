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
    int sum = 0;

for (int i = 1; i < ar.Length; i = i + 2)
{  
    sum = sum + ar[i];
}
     Console.WriteLine(sum);
}

