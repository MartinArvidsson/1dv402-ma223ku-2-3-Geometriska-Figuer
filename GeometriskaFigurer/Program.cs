using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Program
    {
        static void Main(string[] args)
        {            
            do
            {
                Console.Clear();
                ViewMenu(); // Anropar viewmeny (kodad längre ner) för att visa en meny för användaren.
                int options;
                string choice =Console.ReadLine();      //Användaren avslutar med 0 räknar ut en elipse eller rektangel med 1 eller 2
                                                        //skriver man utanför  0- 2 ska ett felmeddeande komma upp.
                try
                {
                    options = int.Parse(choice);
                    if (options <0 || options > 2) //Kollar om användaren matar in mellan 0 o 2
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    switch(options) // Dom 3 alternativen
                    {
                        case 0:
                            Console.WriteLine(); //Stänga av
                            return;
                        case 1:
                            ViewShapeDetail(CreateShape(ShapeType.Elipse)); //Elipse
                            break;
                        case 2:
                            ViewShapeDetail(CreateShape(ShapeType.Rectangle)); // Rektangel
                            break;
                    }
                }
                catch // om man är utanför 0 o 2 skrivs detta ut
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n angav inte ett giltigt tal. Ange ett nummer mellan [0 och 2] tack!\n");
                    Console.ResetColor();
                }
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("tyck för att fortsätta");
                Console.ResetColor();
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        private static Shape CreateShape(ShapeType shapeType) 
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================");

            switch (shapeType)
            {
                case ShapeType.Elipse:
                    Console.WriteLine("-        Elipse         -");
                    break;

                case ShapeType.Rectangle:
                    Console.WriteLine("-        Rektangel       -");
                    break;
            }

            Console.WriteLine("========================");
            Console.ResetColor();


            double length = ReadDoubleGreaterThanZero("ange längden tack.");
            double width = ReadDoubleGreaterThanZero("ange bredden tack.");
           
            if (shapeType == ShapeType.Elipse)
            {
                return new Elipse(length, width);
            }
            else
            {
                return new Rectangle(length, width);
            }
        }
        private static double ReadDoubleGreaterThanZero(String prompt) // Skickar tillbaka ett värde som är större än 1 om det inte stämmer får man en ny chans efter att
        {                                                               // programmet har sagt att man har gjort fel.
            double value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                try
                {
                    value = double.Parse(input);
                    if (value >0)
                    {
                        return value;
                    }
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n FEL! Ange ett tal som är större än 0.\n");
                    Console.ResetColor();
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n FEL! Ange ett tal som är större än 0.\n");
                    Console.ResetColor();
                }
            }
        }

        private static void ViewMenu() // Här är viewmenu som anropas högre upp.
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("===============================");
            Console.WriteLine("=                             =");
            Console.WriteLine("=     Geometriska figurer     =");
            Console.WriteLine("=                             =");
            Console.WriteLine("===============================");
            Console.ResetColor();
            Console.WriteLine("\n 0: Avsluta.");
            Console.WriteLine("\n 1: Elips.");
            Console.WriteLine("\n 2: Rektangel.");
            Console.WriteLine("\n=============================");
            Console.Write("\n Ange menyval mellan [0-2] tack! ");
        }
        private static void ViewShapeDetail(Shape Shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("===============================");
            Console.WriteLine("=                             =");
            Console.WriteLine("=          Detaljer           =");
            Console.WriteLine("=                             =");
            Console.WriteLine("===============================");
            Console.ResetColor();
            Console.WriteLine(Shape.ToString());
            Console.WriteLine("===============================");
        }
    }
}
