﻿//Задача 2: Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет количество чётных чисел в массиве.
Random zufall = new Random();  //зачем-то заранее сообщаем, что будем работать
                                       //с рандомными значениями. Если под это нужно
                                       //выделить память, то мы не сказали, какую памать выделим
int[] array = new int[10];  //создали массив
for (int i = 0; i < array.Length; i++)
    { 
    array[i] = zufall.Next(0, 101); 
    } //заполнили массив рандомными значениями
int count = 0;  // здесь будем считать количество, сколько чисел чётные
for (int i = 0; i<array.Length; i++) // опять пройдёмся по массиву
    {
    if (array[i]%2 == 0) //если условие выполнится
        {
        count++; // увеличиваем счёт
        }
    else { continue; }
    }
Console.WriteLine(count);
