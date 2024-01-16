//Aufgabe 2: Richten Sie ein Array mit 10 Ganzzahlen ein.
//Schreibe ein Programm, das die Anzahl der geraden Zahlen in einem Array bestimmt.﻿
Random zufall = new Random();  //Aus irgendeinem Grund informieren wir Sie im Voraus darüber, dass wir arbeiten werden
                                       //mit zufälligen Werten. Wenn du es brauchst
                                       //Speicher zuweisen, dann haben wir nicht gesagt, welchen Speicher wir zuweisen werden
int[] array = new int[10]; //ein Array erstellt
for (int i = 0; i < array.Length; i++)
    { 
    array[i] = zufall.Next(0, 101); 
    } //das Array mit Zufallswerten gefüllt
int count = 0;  // hier zählen wir die Menge, wie viele Zahlen gerade sind
for (int i = 0; i<array.Length; i++) // Lass uns das Array noch einmal durchgehen
    {
    if (array[i]%2 == 0) //wenn die Bedingung erfüllt ist
        {
        count++; // Erhöhe die Punktzahl
        }
    else { continue; }
    }
Console.WriteLine(count);
