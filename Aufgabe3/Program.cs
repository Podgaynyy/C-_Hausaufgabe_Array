﻿//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
//Найдите разницу между максимальным и минимальным элементов массива.

//в этот раз обошёлся без точки входа и пользуюсь консолью
double[] array = { 0.35, 2.15, 3.17, 8.94, 5.22 }; //создал массив вручную
double min = array[0]; //создали значение для минимума, по умолчанию первый элемент
double max = array[0]; // создали значение для максимума, первый элемент
for (int i = 0; i < array.Length; i++) //пройдёмся по массиву
{
    if (array[i] > max) { max = array[i]; } //если элемент больше значения в минимуме,
                                            //то он новый максимум
    else if (array[i] < min) { min = array[i]; } //если элемент меньше минимума,
                                                 //то он новый минимум
    else { continue; } // если равен, то пропустим
}
double substrahieren = max - min;
Console.WriteLine(substrahieren); // распечатаем разницу