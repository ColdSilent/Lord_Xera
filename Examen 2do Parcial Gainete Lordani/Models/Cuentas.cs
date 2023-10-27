namespace Examen_Gainete.Models
{
    public class Cuentas
    {
        public int id_Cuenta { get; set; }
        public int id_Cliente { get; set; }
        public int Nro_Cuenta { get; set; }
        public DateTime Fecha_Alta { get; set; }
        public char Tipo_Cuenta { get; set; }
        public char Estado { get; set; }
        public float Saldo { get; set; }
        public int Nro_Contrato { get; set; }
        public float Costo_Mantenimiento { get; set; }
        public char Promedio_Acreditacion { get; set; }
        public char moneda { get; set; }
}
}
