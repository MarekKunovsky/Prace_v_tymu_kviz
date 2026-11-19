namespace KvizProjekt;

public class Otazka
{
    public string Text { get; }
    public string Kategorie { get; }
    public int Obtiznost { get; }
    public IReadOnlyList<string> Moznosti { get; }
    public int SpravnaOdpoved { get; }

    public string NazevObtiznosti => Obtiznost switch
    {
        1 => "lehká",
        2 => "střední",
        _ => "těžká"
    };

    public Otazka(string text, string kategorie, int obtiznost,
        IEnumerable<string> moznosti, int spravnaOdpoved)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);
        ArgumentException.ThrowIfNullOrWhiteSpace(kategorie);
        ArgumentNullException.ThrowIfNull(moznosti);

        if (obtiznost is < 1 or > 3)
        {
            throw new ArgumentOutOfRangeException(nameof(obtiznost), "Obtížnost musí být 1 až 3.");
        }

        if (spravnaOdpoved is < 1 or > 4)
        {
            throw new ArgumentOutOfRangeException(nameof(spravnaOdpoved), "Správná odpověď musí být 1 až 4.");
        }

        string[] polozky = moznosti.Select(moznost => moznost?.Trim() ?? "").ToArray();
        if (polozky.Length != 4 || polozky.Any(string.IsNullOrEmpty)
            || polozky.Distinct(StringComparer.OrdinalIgnoreCase).Count() != 4)
        {
            throw new ArgumentException("Otázka musí mít čtyři různé neprázdné možnosti.", nameof(moznosti));
        }

        Text = text.Trim();
        Kategorie = kategorie.Trim();
        Obtiznost = obtiznost;
        Moznosti = Array.AsReadOnly(polozky);
        SpravnaOdpoved = spravnaOdpoved;
    }
}
