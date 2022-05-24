using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEjemplos
{
    public class LinqThenBy
    {
        
        public IEnumerable<Empleado> FuncionFlecha(List<Empleado> empleados)
        {
            return empleados.OrderBy(empleado => empleado.Legajo).ThenBy(x => x.Edad);
        }
    }
}
