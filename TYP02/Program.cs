//Schreiben Sie eine Methode, die den Mittelwert der Werte eines eindimensionalen Feldes von
//double-Variablen berechnet und als Rückgabewert zurückliefert. Testen Sie die Methode durch zwei Aufrufe mit unterschiedlich großen Feldern.

double[] array = new double[5] { 3.1, 6.9, 8.9, 0.2, 5.6 };

static double MittelwertBerechnen(double[] array)
{
   double mittelwert = array.Sum() / array.Length;
   return mittelwert;
}

Console.WriteLine(MittelwertBerechnen(array));
