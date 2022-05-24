using DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace LinqEjemplos
{
    public class LinqMapear
    {
        public IEnumerable<Persona> ComoSql(List<Empleado> empleados)
        {
            return from empleado in empleados
                   select new Persona { Apellido = empleado.Apellido, Nombre = empleado.Nombre };

        }
        public IEnumerable<Persona> FuncionFlecha(List<Empleado> empleados)
        {
            return empleados.Select(x => new Persona { Apellido = x.Apellido, Nombre = x.Nombre });
        }
    }
}
