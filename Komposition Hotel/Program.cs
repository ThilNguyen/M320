public class Hotel
{
    public string Adresse { get; set; }
    public string Name { get; set; }

    public List<Zimmer> ZimmerList = new List<Zimmer>();
    public void AddSitzungszimmer(int nummer, int anzPlaetze)
    {

    }

    public void AddZimmer(int nummer, Bett bett) 
    {
       
    }
}
public class Reception
{
    public string EMailAdresse { get; set; }
    public string TelefonNummer { get; set; }

    public Hotel Hotel { get; set; }
}

public class Zimmer
{
    public List<Bett> Bett = new List<Bett>();
    public int Nummer { get; set; }

    public void AddBett(Bett bett)
    {
        Bett.Add(bett);
    }
    public Zimmer(int nummer, Bett bett)
    {
        Zimmer.AddBett(bett);
    }
    
}
public class Bett
{
    public double Breite { get; set; }
    public Zimmer Zimmer { get; set; }
}

public class Sitzungszimmer
{
    public int AnzahlPlaetze { get; set; }
    public int Nummer { get; set; }
}

public class Beamer
{
    public int Aufloesung { get; set; }
    public string Name { get; set; }
}