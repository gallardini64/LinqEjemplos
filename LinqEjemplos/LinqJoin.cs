using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEjemplos
{
    public class LinqJoin
    {
        public void FuncionFlecha(List<Empleado> empleados, List<Equipo> equipos)
        {
            var result = empleados.Join(
                                    equipos,
                                    empleado => empleado.EquipoId,
                                    equipo => equipo.Id,
                                    (empleado, equipo) => new
                                    {
                                        EmpleadoNombre = empleado.Nombre,
                                        EquipoNombre = equipo.Nombre
                                    }).ToList();
            result.ForEach(x => Console.WriteLine($"{x.EmpleadoNombre} - {x.EquipoNombre}"));
        }
    }
}
