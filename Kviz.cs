namespace KvizProjekt;

public class Kviz
{
    public List<Otazka> Otazky { get; } = new();
    public List<Hrac> Hraci { get; } = new();

    public void Hrat()
    {
        Console.WriteLine("Tato volba se zatím připravuje.");
    }
}
