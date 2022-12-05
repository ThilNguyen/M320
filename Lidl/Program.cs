class Program
{
    static void Main(string[] args)
    {

        PersonPrinter printer = new PersonPrinter();
        PersonNeu personNeu = new PersonNeu();

        Kunde kunde1 = new Kunde() { Vorname ="Fritz", Name="Hans"};
        Lagerist lagerist1 = new Lagerist() { Vorname="Peter", Name ="HOi"};
        Kind kind1=new Kind() { Vorname="Ben", Name="Manser"};

        kunde1.Trage();
        lagerist1.Trage();
        kind1.Trage();

        kunde1.Esse();
        lagerist1.Esse();
        kind1.Esse();

        List<Person> personen = new List<Person>();
        personen.Add(kunde1);
        personen.Add(lagerist1);
        personen.Add(kind1);

        foreach (Person p in personen)
        {
            Console.WriteLine("Ich bin {0} {1}", p.Vorname, p.Name); //Methode Esse() verhält sich nach der Methode des Kindes nicht der Person
            p.Esse();
            p.Trage();
            //p.LagereEin();
        }

        //int kunde1key = kunde1.key;

        //int kunde1identnr = kunde1.identnr;
    }

    public abstract class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }

        //protected int IdentNr { get; } // # = protected
        //private int Key { get; } // - = private
        public Person()
        {
            Console.WriteLine("Konstruktor Person");
        }

        public virtual void Esse()
        {
            //Console.WriteLine($"Identnr = {this.IdentNr}, key = {this.Key}");
            System.Console.WriteLine("Ich als Person {0} {1} esse mit Messer und Gabel", Vorname, Name);
        }

        public abstract void Trage(); //abstract kann keine Implementierung enthalten(keinen body)
         
            

        
    }
    public class Kunde : Person //Kunde erbt von Person
    {
        public int Umsatz { get; set; }
        public void Kaufe()
        {
            //Console.WriteLine($"identnr = {this.identnr}, key = {this.key}"); geht nicht weil key private ist
            System.Console.WriteLine("Ich als Person {0} {1} kaufe bei Lidl ein", Vorname, Name);
        }

    public override void Trage() //override überschreibt Sachen
    {
            Console.WriteLine("Kunde trägt seinen Einkauf");
    }
    }
    public class Lagerist : Person
    {
        public int Groesse { get; set; }
        public Lagerist()
        {
            Console.WriteLine("Konstruktor Lagerist");
        }
        public void LagereEin()
        {
            Console.WriteLine("Ich als Lagerist {0} {1} lagere ein", Vorname, Name);
        }
        public override void Trage()
        {
            Console.WriteLine("Lagerist trägt Ware");
        }
    }
    public class Kind : Person
    {
        public override void Trage()
        {
            Console.WriteLine("Kinder tragen nichts, sondern werden getragen.");
        }
        public override void Esse()
        {
            Console.WriteLine("Kinder werden gefüttert.");
        }
    }

    public interface IPerson
    {
        string Name { get; set; }
        void Trage();
        void Esse();
    }
    public class PersonNeu : IPerson
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void Esse()
        {
            throw new NotImplementedException();
        }
        public void Trage()
        {
            throw new NotImplementedException();
        }
    }
    public class PersonPrinter
    {

    }
}