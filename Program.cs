using System.Text;
using KvizProjekt;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Kviz kviz = new();
SpravaOtazek.NactiUkazky(kviz.Otazky);
SpravaHracu.NactiUkazky(kviz.Hraci);

while (true)
{
    VypisMenu();
    int? volba = Vstup.Cislo("Volba: ", 0, 7);

    switch (volba)
    {
        case null:
        case 0:
            Console.WriteLine("Konec kvízu.");
            return;
        case 1:
            SpravaOtazek.Pridat(kviz.Otazky);
            break;
        case 2:
            SpravaOtazek.VypsatPodleKategorie(kviz.Otazky);
            break;
        case 3:
            SpravaOtazek.Smazat(kviz.Otazky);
            break;
        case 4:
            SpravaHracu.Registrovat(kviz.Hraci);
            break;
        case 5:
            SpravaHracu.Vypsat(kviz.Hraci);
            break;
        case 6:
            kviz.Hrat();
            break;
        case 7:
            SpravaHracu.Zebricek(kviz.Hraci);
            break;
    }
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
