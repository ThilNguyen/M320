using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    public class Rectangle
    {

       
        // Felder/Fields
        // private = Zugriffsmodifizierer
        // Benennung von Felder/Fields = camelCase
        private string name;
        

        private readonly int width = 10;
        private readonly int height = 15;

        // private Color color = Color.Black;

        //public int Area
        //{
        //    get
        //    {
        //        return this.width * this.height;
        //    }
        //}

        // public int Are => this.width * this.height;
        // getter mit Expression Body = eine einzelne Expression ohne geschweifte Klammern

        public int Area { get => this.width * this.height; }

        // public int Area
        // { get; }

        // Eigenschaften/Properties
        // Benennung = PascalCase
        // Property mit einem BackingField
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        // public string Name { get; set; }

        

        public Rectangle(Color color)
        {
            this.color = color;
        }


        // public Color color { private get; set; } = Color.Black;
        // AutoProperty 

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(int width, int height, Color color) : this(width, height)
        {
            this.color = color;
        }
    }
}
