using Xunit;
using UserManagement.Models;
using UserManagement.Services;

namespace UserManagement.Tests
{
    public class UsuarioServiceTests
    {
        //PAra ejecutar las pruebas hay que retaurar paquetes
        //1-package manager console
        //2-dotnet restore
        //3-dotnet test
        //


        //Recomendable dejar test al final para indicar que es una prueba
        //Se debe de emular los datos mas no modificar lo existente
        //Fact es para las pruebas
        [Fact]
        public void InsertUserTest() 
        {
            //Arranque
            //IMPORTANTE Fabricas de objetos investigar como hacerlas
            var servicio = new UsuarioService();
            var usuario = new Usuario(1, "carlos", "qui_gonn_lion@hotmail.com");

            //Acción
            servicio.CrearUsuario(usuario);
            var result = servicio.ObtenerUsuarioPorId(usuario.Id);

            //Aserción (Validación de resultado de la operación)
            Assert.NotNull(result);
            Assert.Equal(usuario.Nombre, result.Nombre);
            Assert.Equal(usuario.Email, result.Email);
            //Assert.Equal(usuario, result);


        }
    }
}