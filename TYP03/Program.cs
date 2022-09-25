//Schreiben Sie eine Methode, die zwei eindimensionale Felder von double-Variablen in einem dritten Feld vereinigt. 
//In dem neuen Feld sollen  alle Werte des ersten Feldes, gefolgt von allen Werten des zweiten Feldes stehen. 
//An die Methode sollen die Verweise auf die ersten beiden Felder und (als Ausgabeparameter) ein Verweis auf das dritte Feld übergeben werden. 
//Das dritte Feld wird erst in der Methode erschaffen. Testen Sie die Methode durch zwei unterschiedliche Aufrufe.

double[] array1 = new double[3] { 3.4, 2.9, 4.8 };
double[] array2 = new double[3] { 8.6, 1.3, 6.1 };

static double[] FeldVereinigen(double[] array1, double[] array2)
{
    double[] array3 = new double[array1.Length + array2.Length];

    for (int i = 0; i < array1.Length; i++)
    {
        array3[i] = array1[i];
    }

    for (int i = 0; i < array2.Length; i++)
    {
        array3[i + array1.Length] = array2[i];
    }

    return array3;
}

double[] array3 = FeldVereinigen(array1, array2);

var output = String.Join(" ; " , array3);
Console.WriteLine(output);