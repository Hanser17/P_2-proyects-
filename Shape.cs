using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_2do
{
   public abstract class Shape
    {
        public double Alto {  get; set; }
        public double Ancho { get; set; }
        public abstract double CalculateShape();
  
      
    }

    public class Triangle : Shape
    {
        public Triangle(double alto, double ancho) 
        {
            Alto= alto;
            Ancho= ancho;
        }
        public override double CalculateShape()
        {
            return (Alto * Ancho) / 2;
           
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle (double alto, double ancho)
        {
            Alto = alto;
            Ancho = ancho;
        }
        public override double CalculateShape()
        {
            return Alto * Ancho;

        }
      
    }

    public class Circle : Shape
    {
        public Circle (double radio)
        {
            Alto = radio;
            Ancho = radio;
        }
        public override double CalculateShape()
        {
            return Math.PI * Math.Pow(Ancho,2);
        }
    }
}
