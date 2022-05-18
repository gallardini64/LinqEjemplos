namespace DataAccess
{
    public class Empleado
    {
        public int Id { get; set; }
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Cargo Puesto { get; set; }
    }
}