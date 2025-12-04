namespace SistemdeaEntradas.Models
{
    public class Ubicaciones
    {
        public int Id { get; set; }
        public int IdEspectaculo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Capacidad { get; set; }
    }
}
