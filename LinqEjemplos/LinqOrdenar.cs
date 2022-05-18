using DataAccess;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqEjemplos
{
    public class LinqOrdenar
    {
        public LinqOrdenar()
        {
        }

        public IEnumerable<Empleado> OrdenarComoSql(List<Empleado> empleados)
        {
            var resultado = from empleado in empleados
                                       orderby empleado.Legajo
                                       select empleado;
            return resultado;
        }
        public IEnumerable<Empleado> OrdenarFuncionFlecha(List<Empleado> empleados)
        {
            var resultado = empleados.OrderBy(empleado => empleado.Legajo);
            return resultado;
        }
    }
}