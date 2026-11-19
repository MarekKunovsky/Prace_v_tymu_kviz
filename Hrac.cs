namespace KvizProjekt;

public class Hrac
{
    public string Jmeno { get; }
    public int NejlepsiSkore { get; private set; }
    public int PocetHer { get; private set; }

    public Hrac(string jmeno)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(jmeno);
        Jmeno = jmeno.Trim();
    }
}
