namespace Examen_Gainete.Models
{
    public class Cliente
    {
        public int id_Cliente { get; set; }
        public int id_Persona { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public char Calificacion { get; set; }
        public char Estado { get; set; }

    }
}
