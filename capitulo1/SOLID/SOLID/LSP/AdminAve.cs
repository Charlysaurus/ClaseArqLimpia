using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    //la funcionalidad no debe de ser afectada sin importar si se usa una clase padre o hijo
    public interface IVolar { void Volar(); }
    public interface ICorrer { void Correr(); }
    public interface INadar { void Nadar(); }

    

    public class Pinguino : INadar, ICorrer
    {
       
        public void Correr()
        {
            Console.WriteLine("corre chistoso!!!");
        }

        public void Nadar()
        {
            Console.WriteLine("si nada muy rápido!!!");
        }
    }

    public class Paloma : IVolar, ICorrer 
    {
       
        public void Correr()
        {
            Console.WriteLine("si corre!!!");
        }

       
        public void Volar()
        {
            Console.WriteLine("si vuela!!!");
        }
    }

    public class Eagle : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("si vuela!!!");
        }
    }

    public class AdminAve
    {
        private List<IVolar> voladores = new List<IVolar>();

        public bool InsertVolador(IVolar ave) 
        {
            voladores.Add(ave);
            return true;
        }
    }
}
