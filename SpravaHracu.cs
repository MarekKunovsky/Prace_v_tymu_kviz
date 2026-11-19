namespace KvizProjekt;

internal static class SpravaHracu
{
    internal static void NactiUkazky(List<Hrac> hraci)
    {
        hraci.Add(new Hrac("Adam"));
        hraci.Add(new Hrac("Eliška"));
    }

    internal static void Registrovat(List<Hrac> hraci)
    {
        string? jmeno = Vstup.Text("Jméno hráče: ");
        if (jmeno is null)
        {
            return;
        }

        if (hraci.Any(hrac => string.Equals(hrac.Jmeno, jmeno, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Hráč s tímto jménem už existuje.");
            return;
        }

        hraci.Add(new Hrac(jmeno));
        Console.WriteLine($"Hráč \"{jmeno}\" byl zaregistrován.");
    }

    internal static void Vypsat(List<Hrac> hraci)
    {
        if (hraci.Count == 0)
        {
            Console.WriteLine("Zatím není zaregistrován žádný hráč.");
            return;
        }

        Console.WriteLine("Hráči:");
        foreach (Hrac hrac in hraci)
        {
            string rekord = hrac.PocetHer == 0 ? "zatím žádný" : $"{hrac.NejlepsiSkore}/5";
            Console.WriteLine($"- {hrac.Jmeno} | hry: {hrac.PocetHer} | rekord: {rekord}");
        }
    }

    internal static void Zebricek(List<Hrac> hraci)
    {
        Console.WriteLine("Tato volba se zatím připravuje.");
    }
}
