namespace KvizProjekt;

internal static class SpravaOtazek
{
    internal static void NactiUkazky(List<Otazka> otazky)
    {
    }

    internal static void Pridat(List<Otazka> otazky)
    {
        string? mesto = Vstup.Text("Název hlavního města: ");
        if (mesto is null)
        {
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

        string[] moznosti = new string[4];
        for (int i = 0; i < moznosti.Length; i++)
        {
            string? moznost = Vstup.Text($"Stát pro možnost {i + 1}: ");
            if (moznost is null)
            {
                return;
            }

            moznosti[i] = moznost;
        }

        if (moznosti.Distinct(StringComparer.OrdinalIgnoreCase).Count() != moznosti.Length)
        {
            Console.WriteLine("Možnosti se musí lišit. Zkus otázku přidat znovu.");
            return;
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
        Console.WriteLine("Tato volba se zatím připravuje.");
    }

    internal static void Smazat(List<Otazka> otazky)
    {
        Console.WriteLine("Tato volba se zatím připravuje.");
    }
}
