namespace KvizProjekt;

internal static class SpravaHracu
{
    internal static void NactiUkazky(List<Hrac> hraci)
    {
    }

    internal static void Registrovat(List<Hrac> hraci)
    {
        string? jmeno = Vstup.Text("Jméno hráče: ");
        if (jmeno is null)
        {
            return;
        }

        hraci.Add(new Hrac(jmeno));
        Console.WriteLine($"Hráč \"{jmeno}\" byl zaregistrován.");
    }

    internal static void Vypsat(List<Hrac> hraci)
    {
        Console.WriteLine("Tato volba se zatím připravuje.");
    }

    internal static void Zebricek(List<Hrac> hraci)
    {
        Console.WriteLine("Tato volba se zatím připravuje.");
    }
}
