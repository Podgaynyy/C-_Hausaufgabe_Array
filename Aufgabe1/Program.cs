//Aufgabe 1: Geben Sie ein eindimensionales Array mit 10 Ganzzahlen von 1 bis 100 an.
//Finden Sie die Anzahl der Array-Elemente, deren Werte im Intervall [20,90] liegen.

namespace Aufgabe_one;         // Dadurch wird das Projekt erstellt. Ich weiß nicht, ob das notwendig ist, wie in Java
internal class Program
{
    static void Main(string[] args)
    {
        Random zufall = new Random();  //Aus irgendeinem Grund informieren wir Sie im Voraus darüber, dass wir arbeiten werden
                                       //mit zufälligen Werten. Wenn du es brauchst
                                       //Speicher zuweisen, dann haben wir nicht gesagt, welchen Speicher wir zuweisen werden
        int[] array = new int[10];  //ein Array erstellt
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = zufall.Next(0, 101); //das Array mit Zufallswerten gefüllt
        }
        int count = 0;  // hier zählen wir die Anzahl der erfüllten Bedingungen
        for (int i = 0; i < array.Length; i++) // Lass uns das Array noch einmal durchgehen
        {
            if (array[i] > 20 && array[i] < 80) //wenn die Bedingung erfüllt ist
            {
                count++; // Erhöhe die Punktzahl
            }
            else { continue; }
        }
        Console.WriteLine(count);

    }
}
