using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_2do
{
    internal class Program
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(alto:2,ancho:4),
                new Triangle(alto: 7, ancho: 4),
                new Circle(radio: 10)

            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"El area de la forma {shape.GetType().Name} es: {shape.CalculateShape() }");
            }
            Console.ReadLine();

        }
    }
}
