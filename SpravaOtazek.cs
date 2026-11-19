namespace KvizProjekt;

internal static class SpravaOtazek
{
    internal static void NactiUkazky(List<Otazka> otazky)
    {
        otazky.AddRange(UkazkoveOtazky.Vytvor());
    }

    internal static void Pridat(List<Otazka> otazky)
    {
        string? mesto = Vstup.Text("Název hlavního města: ");
        if (mesto is null)
        {
            return;
        }

        if (otazky.Any(otazka => string.Equals(otazka.Text, mesto, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Otázka na toto hlavní město už existuje.");
            return;
        }

        string? kategorie = Vstup.Text("Kategorie (např. Evropa): ");
        if (kategorie is null)
        {
            return;
        }

        int? obtiznost = Vstup.Cislo("Obtížnost (1 lehká, 2 střední, 3 těžká): ", 1, 3);
        if (obtiznost is null)
        {
            return;
        }

        List<string> moznosti = new();
        while (moznosti.Count < 4)
        {
            string? moznost = Vstup.Text($"Stát pro možnost {moznosti.Count + 1}: ");
            if (moznost is null)
            {
                return;
            }

            if (moznosti.Contains(moznost, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Tento stát už je mezi možnostmi. Zadej jiný.");
                continue;
            }

            moznosti.Add(moznost);
        }

        int? spravna = Vstup.Cislo("Číslo správné odpovědi (1–4): ", 1, 4);
        if (spravna is null)
        {
            return;
        }

        otazky.Add(new Otazka(mesto, kategorie, obtiznost.Value, moznosti, spravna.Value));
        Console.WriteLine($"Otázka \"{mesto}\" byla přidána.");
    }

    internal static void VypsatPodleKategorie(List<Otazka> otazky)
    {
        if (otazky.Count == 0)
        {
            Console.WriteLine("Seznam otázek je prázdný.");
            return;
        }

        IEnumerable<string> kategorieVSeznamu = otazky.Select(otazka => otazka.Kategorie)
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .OrderBy(kategorie => kategorie, StringComparer.CurrentCultureIgnoreCase);
        Console.WriteLine($"Dostupné kategorie: {string.Join(", ", kategorieVSeznamu)}");

        string? kategorie = Vstup.Text("Kategorie pro výpis: ");
        if (kategorie is null)
        {
            return;
        }

        Otazka[] nalezene = otazky
            .Where(otazka => string.Equals(otazka.Kategorie, kategorie, StringComparison.OrdinalIgnoreCase))
            .ToArray();

        if (nalezene.Length == 0)
        {
            Console.WriteLine($"V kategorii \"{kategorie}\" nejsou žádné otázky.");
            return;
        }

        Console.WriteLine($"Počet otázek v kategorii: {nalezene.Length}");
        foreach (Otazka otazka in nalezene)
        {
            Console.WriteLine($"- {otazka.Text} ({otazka.NazevObtiznosti})");
        }
    }

    internal static void Smazat(List<Otazka> otazky)
    {
        Console.WriteLine("Tato volba se zatím připravuje.");
    }
}
