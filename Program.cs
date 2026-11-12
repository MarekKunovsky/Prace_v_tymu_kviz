using System.Text;
using KvizProjekt;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

while (true)
{
    VypisMenu();
    int? volba = Vstup.Cislo("Volba: ", 0, 7);
    if (volba is null or 0)
    {
        Console.WriteLine("Konec kvízu.");
        return;
    }

    Console.WriteLine("Tato volba se zatím připravuje.");
}

static void VypisMenu()
{
    Console.WriteLine();
    Console.WriteLine("=== Kvíz – hlavní města ===");
    Console.WriteLine("1. Přidat otázku");
    Console.WriteLine("2. Vypsat otázky podle kategorie");
    Console.WriteLine("3. Smazat otázku");
    Console.WriteLine("4. Registrovat hráče");
    Console.WriteLine("5. Vypsat hráče");
    Console.WriteLine("6. Hrát kvíz");
    Console.WriteLine("7. Zobrazit žebříček");
    Console.WriteLine("0. Konec");
}
