using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class Repository : IRepository
    {
        public IEnumerable<Empleado> GetAll()
        {
            return new List<Empleado>()
            {
                new Empleado() { Id = 1, Legajo = 46366, Nombre = "Pablo", Apellido = "Galvan", Puesto = Cargo.Dueño, Edad = 50, EquipoId = 1},
                new Empleado() { Id = 2, Legajo = 56181, Nombre = "Jose", Apellido = "Gonzalez", Puesto = Cargo.DevOps, Edad = 25, EquipoId = 1},
                new Empleado() { Id = 3, Legajo = 16512, Nombre = "Pedro", Apellido = "Rodriguez", Puesto = Cargo.Analista, Edad = 26, EquipoId = 1},
                new Empleado() { Id = 4, Legajo = 48731, Nombre = "Ana", Apellido = "Gomez", Puesto = Cargo.Gerente, Edad = 30, EquipoId = 1},
                new Empleado() { Id = 5, Legajo = 65132, Nombre = "Ailen", Apellido = "Fernandez", Puesto = Cargo.Tester, Edad = 28, EquipoId = 1},
                new Empleado() { Id = 6, Legajo = 13215, Nombre = "Josefina", Apellido = "Lopez", Puesto = Cargo.Desarrollador, Edad = 20, EquipoId = 1},
                new Empleado() { Id = 7, Legajo = 89732, Nombre = "Facundo", Apellido = "Martinez", Puesto = Cargo.Desarrollador, Edad = 21, EquipoId = 2},
                new Empleado() { Id = 8, Legajo = 76558, Nombre = "Franco", Apellido = "Diaz", Puesto = Cargo.Desarrollador, Edad = 19, EquipoId = 2},
                new Empleado() { Id = 9, Legajo = 16813, Nombre = "Roberto", Apellido = "Perez", Puesto = Cargo.QA, Edad = 23, EquipoId = 2},
                new Empleado() { Id = 10, Legajo = 68793, Nombre = "Sabrina", Apellido = "Sanchez", Puesto = Cargo.QA, Edad = 19, EquipoId = 2},
                new Empleado() { Id = 11, Legajo = 13548, Nombre = "Mara", Apellido = "Romero", Puesto = Cargo.Desarrollador, Edad = 18, EquipoId = 2},
                new Empleado() { Id = 12, Legajo = 79318, Nombre = "Martina", Apellido = "Garcia", Puesto = Cargo.DevOps, Edad = 45, EquipoId = 3},
                new Empleado() { Id = 13, Legajo = 86743, Nombre = "Gonzalo", Apellido = "Messi", Puesto = Cargo.Tester, Edad = 30, EquipoId = 3},
                new Empleado() { Id = 14, Legajo = 18733, Nombre = "Erik", Apellido = "Rojas", Puesto = Cargo.Analista, Edad = 27, EquipoId = 3},
                new Empleado() { Id = 15, Legajo = 77777, Nombre = "Gonzalo", Apellido = "Acosta", Puesto = Cargo.Desarrollador, Edad = 28, EquipoId = 1},
                new Empleado() { Id = 16, Legajo = 13546, Nombre = "Luis", Apellido = "Flores", Puesto = Cargo.QA, Edad = 39, EquipoId = 3},
                new Empleado() { Id = 17, Legajo = 99999, Nombre = "Mauricio", Apellido = "Torres", Puesto = Cargo.Desarrollador, Edad = 49, EquipoId = 2}
            };
        }

        public IEnumerable<Equipo> GetAllEquipos()
        {
            return new List<Equipo>()
            {
                new Equipo() { Id = 1, Nombre = "Argentina" },
                new Equipo() { Id = 2, Nombre = "Uruguay" },
                new Equipo() { Id = 3, Nombre = "Peru" }
            };
        }
    }
}
