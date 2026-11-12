namespace KvizProjekt;

internal static class Vstup
{
    internal static int? Cislo(string vyzva, int minimum, int maximum)
    {
        while (true)
        {
            Console.Write(vyzva);
            string? radek = Console.ReadLine();
            if (radek is null)
            {
                return null;
            }

            if (int.TryParse(radek, out int cislo) && cislo >= minimum && cislo <= maximum)
            {
                return cislo;
            }

            Console.WriteLine($"Zadej celé číslo od {minimum} do {maximum}.");
        }
    }

    internal static string? Text(string vyzva)
    {
        while (true)
        {
            Console.Write(vyzva);
            string? radek = Console.ReadLine();
            if (radek is null)
            {
                return null;
            }

            string text = radek.Trim();
            if (text.Length > 0)
            {
                return text;
            }

            Console.WriteLine("Zadej neprázdný text.");
        }
    }
}
