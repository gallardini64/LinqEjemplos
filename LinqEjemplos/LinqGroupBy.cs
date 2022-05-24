using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEjemplos
{
    public class LinqGroupBy
    {
        public void ComoSql(List<Empleado> empleados)
        {
            var result = from empleado in empleados
                   group empleado by empleado.Puesto;
            MostrarAgrupados(result);
        }
        public void FuncionFlecha(List<Empleado> empleados)
        {
            var result = empleados.GroupBy(x => x.Puesto);
            MostrarAgrupados(result);
        }
        public void FuncionFlechaToLookUp(List<Empleado> empleados)
        {
            var result = empleados.ToLookup(x => x.Puesto);
            MostrarAgrupados(result);
        }

        private void MostrarAgrupados(IEnumerable<IGrouping<Cargo, Empleado>> empleadosAgrupados)
        {
            foreach (var cargo in empleadosAgrupados)
            {
                Console.WriteLine($"----{cargo.Key}----" ); 

                foreach (var s in cargo)
                    Console.WriteLine(s.Nombre);
            }
        }
    }
}
