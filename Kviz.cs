namespace KvizProjekt;

public class Kviz
{
    private const int PocetOtazekVKole = 5;

    public List<Otazka> Otazky { get; } = new();
    public List<Hrac> Hraci { get; } = new();

    public void Hrat()
    {
        Hrac? hrac = VyberHrace();
        if (hrac is null)
        {
            return;
        }

        Console.WriteLine("Obtížnost:");
        Console.WriteLine("1. Lehká");
        Console.WriteLine("2. Střední");
        Console.WriteLine("3. Těžká");
        Console.WriteLine("0. Zpět do menu");
        int? obtiznost = Vstup.Cislo("Volba obtížnosti: ", 0, 3);
        if (obtiznost is null or 0)
        {
            return;
        }

        Otazka[] dostupneOtazky = Otazky
            .Where(otazka => otazka.Obtiznost == obtiznost.Value)
            .ToArray();
        if (dostupneOtazky.Length < PocetOtazekVKole)
        {
            Console.WriteLine($"Pro tuto obtížnost je dostupných {dostupneOtazky.Length} otázek. "
                + $"Na kolo je potřeba {PocetOtazekVKole}.");
            return;
        }

        Console.WriteLine($"Pro hráče {hrac.Jmeno} je připraveno {dostupneOtazky.Length} otázek vybrané obtížnosti.");
    }

    private Hrac? VyberHrace()
    {
        if (Hraci.Count == 0)
        {
            Console.WriteLine("Nejdřív zaregistruj hráče přes volbu 4.");
            return null;
        }

        Console.WriteLine("Vyber hráče:");
        for (int i = 0; i < Hraci.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Hraci[i].Jmeno}");
        }

        Console.WriteLine("0. Zpět do menu");
        int? volba = Vstup.Cislo("Číslo hráče: ", 0, Hraci.Count);
        return volba is null or 0 ? null : Hraci[volba.Value - 1];
    }
}
