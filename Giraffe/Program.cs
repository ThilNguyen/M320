using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console.WriteLine
            //string characterName = "Tom";
            //int characterAge;
            // characterAge = 25;
            // Console.WriteLine("There once was a man named " + characterName);
            //Console.WriteLine("He was " + characterAge + " years old");

            //characterName = "Mike";
            //Console.WriteLine("He really liked the name " + characterName);
            //Console.WriteLine("But didn't like being " + characterAge);




            #endregion

            #region Data Types
            //string phrase = "Giraffe Academy";
            //char grade = 'A';
            //int age = 30;
            //double gpa = 3.3;
            //bool isMale = true;

            //Console.WriteLine(30);


            #endregion

            #region Strings
            //string satz = "Giraffe Academy";
            //Console.WriteLine(satz.Substring(8, 3));

            #endregion

            #region User Input
            // Console.Write("Enter your name: "); //Write bleibt auf der gleichen Linie
            // string name = Console.ReadLine();
            // Console.Write("Enter your age: ");
            // string alter = Console.ReadLine();
            // Console.WriteLine("Hello " + name + " you are " + alter + " years old"); //WriteLine geht zur nächsten Linie

            #endregion

            #region Calculator
            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);
            #endregion

            #region Mad Lib
            //string color, pluralNoun, celebrity;

            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();

            //Console.Write("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.Write("Enter a celebrity: ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I love " + celebrity);
            #endregion

            #region Arrays
            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //string[] friends = new string[5]; //kann jetzt 5 Werte aufnehmen
            //friends[0] = "Jim";
            //friends[1] = "Kelly";

            //luckyNumbers[1] = 900;

            //Console.WriteLine(luckyNumbers.Length);
            //Console.WriteLine(luckyNumbers[1]);
            #endregion

            #region Methods
            //SayHi("Mike", 33);
            //SayHi("John", 56);
            //SayHi("Tom", 12);
            #endregion

            #region Return Statement
            //int cubedNumber = cube(5);
            //Console.WriteLine(cubedNumber);

            //Console.WriteLine(cube(5));
            #endregion

            #region if-statement
            //bool isMale = false;
            //bool isTall = false;

            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male");
            //} else if (isMale && !isTall)
            //{
            //    Console.WriteLine("You are a short male");
            //} else if (!isMale && isTall)
            //{
            //    Console.WriteLine("You are not male but you are tall");
            //} else
            //{
            //    Console.WriteLine("You are not male and not tall");
            //}
            #endregion

            #region More If Statements
            //Console.WriteLine(GetMax(20, 10, 40));
            #endregion

            #region Classes and Objects
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700);
            //book2.title = "Lord of the Rings";  //braucht man nicht mehr, da alle Namen als Parameter angegeben werden
            //book2.author = "Tolkein";
            //book2.pages = 700;
            Book book3 = new Book();

            book2.title = "The hobbit";

            Console.WriteLine(book2.title);

            #endregion

            Console.ReadLine();
        }

        #region Methods
        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + " you are " + age);
        //}
        #endregion

        #region Return Statement
        //static int cube(int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}
        #endregion

        #region More If Statements
        //static int GetMax(int num1, int num2, int num3)
        //{
        //    int result;
        //    if (num1 >= num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    } else if (num2 >= num1 && num2 >= num3)
        //    {
        //        result = num2;
        //    } else
        //    {
        //        result = num3;
        //    }

        //    return result;
        //}
        #endregion
    }
}
