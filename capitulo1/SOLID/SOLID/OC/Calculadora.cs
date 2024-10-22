using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OC
{

    //Escribir nuevo codigo sin modificar lo existente
    public interface IArea 
    {
        double Area();
    }

    public class Square : IArea
    {
        public double lado {  get; set; }

        public double Area() 
        {
            return lado * lado; ;
        }
    }

    public class Triangle : IArea
    {
        public double Base { get; set; }
        public double Heigt {  get; set; }

        public double Area() 
        {
            return (Base * Heigt) / 2;
        }
    }

    public class Rectabgle : IArea
    {
        public double Base { get; set; }
        public double Heigt { get; set; }

        public double Area()
        {
            return Base * Heigt;
        }
    }

    public class Calculadora
    {
        public double Area(IArea obj) 
        {
            return obj.Area();
        }
    }
}
