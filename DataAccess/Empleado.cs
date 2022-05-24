namespace DataAccess
{
    public class Empleado
    {
        public int Id { get; set; }
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Cargo Puesto { get; set; }
        public int Edad { get; set; }
        public int EquipoId { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Legajo: {Legajo}, Nombre: {Nombre}, Apellido: {Apellido}, Cargo: {Puesto}";
        }
    }
}