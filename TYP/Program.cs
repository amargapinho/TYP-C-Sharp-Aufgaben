//Erstelle eine Konsolenanwendung in der Benutzer so lange aufgefordert wird, 
//eine ganze Integer - Zahl einzugeben, bis dies erfolgreich war.

int zahl1 = 8;
Console.WriteLine("Bitte geben sie ein Zahl zwischen 1 und 10 ein");
int zahl2 = Convert.ToInt32(Console.ReadLine());

while (zahl1 != zahl2)
{
    Console.WriteLine("Bitte versuchen sie nochmal");
    zahl2 = Convert.ToInt32(Console.ReadLine());
}
