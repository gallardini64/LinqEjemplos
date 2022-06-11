using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEjemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var empleado = new Empleado();
            Console.WriteLine(empleado.Edad.ToString());
            Console.ReadKey();
            //IRepository repository = new Repository();
            //var ejemplo = new LinqOrdenar();
            //#region Join
            ////ejemplo.FuncionFlecha(repository.GetAll().ToList(),repository.GetAllEquipos().ToList());
            //#endregion
            //Mostrar(repository.GetAll(), "Antes:");
            //var resultado = ejemplo.ComoSql(repository.GetAll().ToList());
            //Mostrar(resultado, "Despues:");
        }

        private static void Mostrar(IEnumerable<Empleado> resultado, string mensaje = "")
        {
            if (mensaje == "") Console.WriteLine(Environment.NewLine); else Console.WriteLine(mensaje);
            resultado.ToList().ForEach(empleado => Console.WriteLine(empleado.ToString()));
        }
    }
}
