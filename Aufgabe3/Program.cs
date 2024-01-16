//Aufgabe 3: Geben Sie ein Array reeller Zahlen mit einem Bruchteil ungleich Null an.
//Ermitteln Sie die Differenz zwischen den maximalen und minimalen Elementen des Arrays.


//Dieses Mal habe ich auf einen Einstiegspunkt verzichtet und die Konsole verwendet
double[] array = { 0.35, 2.15, 3.17, 8.94, 5.22 }; //das Array manuell erstellt
double min = array[0]; //einen Wert für das Minimum erstellt, standardmäßig das erste Element
double max = array[0]; // einen Wert für das Maximum erstellt, das erste Element
for (int i = 0; i < array.Length; i++) //Lass uns das Array durchgehen
{
    if (array[i] > max) { max = array[i]; } //wenn das Element größer als der Mindestwert ist,
                                            //dann ist es ein neues Maximum
    else if (array[i] < min) { min = array[i]; } //wenn das Element kleiner als das Minimum ist,
                                                 //dann ist es ein neues Minimum
    else { continue; } // wenn gleich, dann überspringen
}
double substrahieren = max - min;
Console.WriteLine(substrahieren); 
// Differenz ausgeben
