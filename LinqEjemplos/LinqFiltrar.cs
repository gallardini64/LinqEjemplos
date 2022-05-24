using DataAccess;
using System.Linq;
using System.Collections.Generic;

namespace LinqEjemplos
{
    public class LinqFiltrar
    {
        public IEnumerable<Empleado> ComoSql(List<Empleado> empleados)
        {
            var resultado = from empleado in empleados
                            where empleado.Puesto == Cargo.Desarrollador
                            select empleado;
            return resultado;
        }
        public IEnumerable<Empleado> FuncionFlecha(List<Empleado> empleados)
        {
            var resultado = empleados.Where(empleado => empleado.Puesto == Cargo.Desarrollador);
            return resultado;
        }
    }
}
