namespace Assoziation
{
    //zu n Assoziationen macht man mit einer Liste
    //1 Assoziation wird mit Navigation gemacht
    //Bei einer bestimmten Assoziation benutzt man ein Array: Beispiel 1..3 Kinder
    internal class Program
    {
        static void Main(string[] args)
        {
            var fan1 = new Fan();
            var fan2 = new Fan();
            var fan3 = new Fan();
            var fan4 = new Fan();

            var star =  new Star();

            //star.AddFan(fan1);
            //star.AddFan(fan2);
            //star.AddFan(fan3);

            fan1.Star = star;
            fan2.Star = star;
            fan3.Star = star;

            Vater fritz = new Vater();
            Kind hansli = new Kind();

            fritz.Kind = hansli;
            hansli.Vater = fritz;

            Hund fido = new Hund();
            Hund monti = new Hund();

            Laus laus1 = new Laus(fido);
            Laus laus2 = new Laus(fido);
            Laus laus3 = new Laus(monti);

            //fido.AddParasit(laus1);
            //fido.AddParasit(laus2);

            //monti.AddParasit(laus3);

            //laus1.Wirt = fido;
            //laus2.Wirt = fido;

            //laus3.Wirt = monti;

            KundeBibliothek meier = new KundeBibliothek();
            KundeBibliothek mueller = new KundeBibliothek();

            Buch cSharp = new Buch();
            Buch java = new Buch();

            meier.Leiht(java);
            mueller.Leiht(java);


            Schulhaus schulhaus = new Schulhaus();
            schulhaus.AddZimmer();
            schulhaus.AddZimmer();


            Firma firma = new Firma();
            firma.AddMitarbeiter();
            firma.AddMitarbeiter();

            Mitarbeiter mitarbeiter = new Mitarbeiter();
            mitarbeiter.AddFirma(firma);
            mitarbeiter.AddFirma();

            Kunde kunde1 = new Kunde();
            kunde1.Name = "Meier";
            kunde1.Vorname = "Fritz";
            kunde1.Umsatz = 90456.45;
        }
    }


    public class Fan
    {
        //private Star star;
        public Star Star { get; set; }
    }
    public class Star
    {
        ////Array
        ////private Fan[] fans = new Fan[100];
        //Liste? keine Ahnung
        //private List<Fan> fans = new List<Fan>();
        //public void AddFan(Fan fan)
        //{
        //    this.fans.Add(fan);
        //}
    }


    public class Vater
    {
        public Kind Kind { get; set; }
    }
    public class Kind
    {
        public Vater Vater { get; set; }
    }

    public class Hund
    {
        // 0..* Multiplizität mit Liste
        private List<Laus> parasiten = new List<Laus>();

        public void AddParasit(Laus parasit)
        {
            parasiten.Add(parasit);
        }
    }

    public class Laus
    {
        //private Property mit Wert via Konstruktor ergibt genau 1..1
        private Hund Wirt { get; set; }

        public Laus(Hund wirt)
        {
            this.Wirt = wirt;
            wirt.AddParasit(this);
        }
    }

    public class KundeBibliothek
    {
        private List<Buch> buecher = new List<Buch>();
        public void Leiht(Buch buch)
        { if (!buch.IstAusgeliehen)
            {
                buecher.Add(buch);
                buch.IstAusgeliehen = true;
            }
            else
            {
                Console.WriteLine("Buch ist bereits ausgeliehen.");
            }
        }
        public void Retourniert(Buch buch)
        {
            if (this.buecher.Contains(buch))
            {
                this.buecher.Remove(buch);
                buch.IstAusgeliehen = false;
            }
        }
    }

    public class Buch
    {
        public bool IstAusgeliehen { get; set; }
    }

    public class Notebook
    {
        private Festplatte Festplatte { get; set; }
        public Notebook(Festplatte festplatte)
        {
            this.Festplatte = festplatte;
        }
    }

    public class Festplatte
    {

    }

    public class Schulhaus
    {
        private List<Zimmer> zimmerList = new List<Zimmer>();

        public Schulhaus()
        {
            this.zimmerList.Add(new Zimmer(this));
        }

        public void AddZimmer()
        {
            this.zimmerList.Add(new Zimmer(this));
        }

        public void AddZimmer(Zimmer zimmer)
        {
            this.zimmerList.Add(zimmer);
        }
    }

    public class Zimmer
    {
        private Zimmer()
        {

        }

        public Zimmer(Schulhaus schulhaus)
        {
            schulhaus.AddZimmer(this);
        }
    }

    public class Firma
    {
        private List<Mitarbeiter> mitarbeiterList = new List<Mitarbeiter>();

        public Firma()
        {
            this.mitarbeiterList.Add(new Mitarbeiter());
        }

        public void AddMitarbeiter()
        {
            this.mitarbeiterList.Add(new Mitarbeiter());
        }

        public void AddMitarbeiter(Mitarbeiter mitarbeiter)
        {
            this.mitarbeiterList.Add(mitarbeiter);
        }
    }

    public class Mitarbeiter
    {
        private List<Firma> firmaList = new List<Firma>();

        public Mitarbeiter()
        {
            this.firmaList.Add(new Firma());
        }

        public void AddFirma()
        {
            this.firmaList.Add(new Firma());
        }

        public void AddFirma(Firma firma)
        {
            this.firmaList.Add(firma);
        }
    }

    public class Kunde1
    {
    
    }

    public class Konto
    {
        private Kunde1 Kunde1 { get; set; }
        public Konto(Kunde1 kunde1)
        {
            this.Kunde1 = kunde1;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
    }

    public class Kunde : Person 
    {
        public double Umsatz { get; set; }
    }

    public class Lagerist : Person
    {
        public int Groesse { get; set; }
    }
}