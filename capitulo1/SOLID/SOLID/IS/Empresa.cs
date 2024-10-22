using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.IS
{
    //tener las interfaces que se necesiten

    public interface ICommons { void EnrarAReuniones(); void Registro(); }

    public interface IDevelop { void Desarrollar(); void Pruebas(); }

    public interface IGerenciar { void Gerenciar(); }

    public interface IFinanzas { void AdministrarFacturas(); }





    public class Developer : ICommons, IDevelop
    {
        public void Desarrollar()
        {
            throw new NotImplementedException();
        }

        public void EnrarAReuniones()
        {
            throw new NotImplementedException();
        }

        public void Pruebas()
        {
            throw new NotImplementedException();
        }

        public void Registro()
        {
            throw new NotImplementedException();
        }
    }

    public class Venta : ICommons
    {
        public void EnrarAReuniones()
        {
            throw new NotImplementedException();
        }

        public void Registro()
        {
            throw new NotImplementedException();
        }
    }

    public class Empresa
    {
    }
}
