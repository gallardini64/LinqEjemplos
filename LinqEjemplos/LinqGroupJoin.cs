using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEjemplos
{
    public class LinqGroupJoin
    {
        public void FuncionFlecha(List<Empleado> empleados, List<Equipo> equipos)
        {
            var result = equipos.GroupJoin(
                                    empleados,
                                    equipo => equipo.Id,
                                    Empleado => Empleado.EquipoId,
                                    (equipo, empleadosAgrupados) => new
                                    {
                                        EmpleadosAgrupados = empleadosAgrupados,
                                        EquipoNombre = equipo.Nombre
                                    }).ToList();

            foreach (var cargo in result)
            {
                Console.WriteLine($"----{cargo.EquipoNombre}----");

                foreach (var s in cargo.EmpleadosAgrupados)
                    Console.WriteLine(s.Nombre);
            }
        }
        

    }
}
