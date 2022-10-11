using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramStart();
        }

        static void ProgramStart()
        {
            Console.Write($"\n\tVad vill du göra?" +
                $"\n\t[1] Räkna ut arean på en cirkel / volymen på en boll" +
                $"\n\t[2] Räkna ut arean på en fyrkant / volymen på en kub" +
                $"\n\t[3] Räkna ut arean på en trekant / volymen på en pyramid" +
                $"\n\t[4] Stäng av programmet" +
                $"\n\t: ");
            int.TryParse(Console.ReadLine(), out int userChoice);
            Console.Clear();

            switch (userChoice)
            {
                case 1:
                    CalculateCircle();
                    break;
                case 2:
                    CalculateSquare();
                    break;
                case 3:
                    CalculateTriangle();
                    break;
                case 4:
                    break;
                default:
                    Console.Write($"\n\tDu angav en ogiltlig karaktär!" +
                        "\n\tTryck enter för att försöka igen!");
                    Console.ReadLine();
                    Console.Clear();
                    ProgramStart();
                    break;
            }
        }

        static void CalculateCircle()
        {
            Console.Write("\n\tAnge radien i cm som du vill räkna med" +
                "\n\t: ");
            float.TryParse(Console.ReadLine(), out float radius);
            Circle circle = new Circle(radius);
            Console.Write($"\n\tArean på en cirkel med {radius}cm i radie är {circle.GetAreaCircle()}cm" +
                $"\n\tVolymen på en boll med {radius}cm i radie är {circle.GetVolumeSphere()}cm");
            Console.ReadLine();
            Console.Clear();
            ProgramStart();
        }

        static void CalculateSquare()
        {
            Console.Write("\n\tAnge Längden på kanten i cm som du vill räkna med" +
                "\n\t: ");
            int.TryParse(Console.ReadLine(), out int length);
            Square square = new Square(length);
            Console.Write($"\n\tArean på en fyrkant med en {length}cm lång kant är {square.GetSquareArea()}cm" +
                $"\n\tVolymen på en kub med en {length}cm lång kant är {square.GetCubeVolume()}cm");
            Console.ReadLine();
            Console.Clear();
            ProgramStart();
        }

        static void CalculateTriangle()
        {
            Console.Write("\n\tAnge basen i cm på en rätvinklig triangel" +
                "\n\t: ");
            float.TryParse(Console.ReadLine(), out float _base);
            Console.Write("\n\tAnge höjden i cm på en rätvinklig triangel" +
                "\n\t: ");
            float.TryParse(Console.ReadLine(), out float height);
            Triangle triangle = new Triangle(_base, height);
            Console.Write($"\n\tArean på en rätvinklig triangel med basen {_base}cm och " +
                $"höjden {height}cm är {triangle.GetTriangleArea()}cm" +
                $"\n\tVolymen på en pyramid med basen {_base}cm och " +
                $"höjden {height}cm är {triangle.GetPyramidVolume()}cm");
            Console.ReadLine();
            Console.Clear();
            ProgramStart();
        }
    }
}
