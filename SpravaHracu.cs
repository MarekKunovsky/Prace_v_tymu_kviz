using System.Globalization;

namespace KvizProjekt;

internal static class SpravaHracu
{
    private static readonly StringComparer CeskeRazeni =
        StringComparer.Create(CultureInfo.GetCultureInfo("cs-CZ"), ignoreCase: true);

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
        Hrac[] poradi = hraci.Where(hrac => hrac.PocetHer > 0)
            .OrderByDescending(hrac => hrac.NejlepsiSkore)
            .ThenBy(hrac => hrac.Jmeno, CeskeRazeni)
            .ToArray();

        if (poradi.Length == 0)
        {
            Console.WriteLine("Zatím nikdo nedohrál kolo.");
            return;
        }

        Console.WriteLine("Žebříček hráčů:");
        for (int i = 0; i < poradi.Length; i++)
        {
            Hrac hrac = poradi[i];
            Console.WriteLine($"{i + 1}. {hrac.Jmeno} – {hrac.NejlepsiSkore}/5");
        }
    }
}
