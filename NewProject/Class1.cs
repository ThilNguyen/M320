using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Program
    {
        public static void Main(string[] args) 
        {
          
            Rectangle rectangle1 = new Rectangle(10, 18);
            rectangle1.Name = "r1"; // setter von Name
            Console.WriteLine(rectangle1.Name); // getter von Name
            Console.WriteLine($"Fläche: {rectangle1.Area}");

          

            // rectangle1 Objekt der Klasse

            Rectangle rectangle2 = new Rectangle(10, 18, Color.Green);
            rectangle2.Name = "r2";
            Console.WriteLine(rectangle2.Name);
            Console.WriteLine($"Fläche: {rectangle2.Area}");

            Rectangle rectangle3 = new Rectangle();

            Rectangle rectangle4 = new Rectangle(); 

        }
        
    }
}
