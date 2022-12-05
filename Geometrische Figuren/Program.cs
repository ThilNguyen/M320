namespace Geometrische_Figuren
{
    class Program
    {
        static void Main(string[] args)
        {
            Figuren figuren = new Figuren();
            figuren.Position();
        }

        public class Figuren
        {
            public float KoordinateX { get; set; } = 100.0f;
            public float KoordinateY { get; set; } = 100.0f;

            public void Position()
            {
                Console.WriteLine("Koordinate X eingeben:");
                float KoordinateX = float.Parse(Console.ReadLine());
                Console.WriteLine("Koordinate X ist: " + KoordinateX);
            }

            public Figuren(float x, float y)
            {
                KoordinateX = x;
                KoordinateY = y;
            }
        }

      
        public class Kreis : Figuren
        {
            
        }

        public class Dreieck : Figuren
        {

        }

        public class Rechteck : Figuren
        {

        }
    }
   
}