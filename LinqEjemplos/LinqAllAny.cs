using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqEjemplos
{
    public class LinqAllAny
    {
        public bool FuncionFlechaAll(List<Empleado> empleados)
        {
            return empleados.All(empleado => empleado.Edad > 17 && empleado.Edad < 100);
        }
        public bool FuncionFlechaAny(List<Empleado> empleados)
        {
            return empleados.Any(empleado => empleado.Edad > 18);
        }
    }
}
