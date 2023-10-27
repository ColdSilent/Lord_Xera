namespace Examen_Gainete.Models
{
    public class Movimientos
    {
        public int id_Movimientos { get; set; }
        public int id_Cuenta { get; set; }
        public DateTime Fecha_Movimiento { get; set; }
        public char Tipo_Movimiento { get; set; }
        public float Saldo_Anterior { get; set; }
        public float Saldo_Actual { get; set; }
        public float Monto_Movimiento { get; set; }
        public float Cuenta_Origen { get; set; }
        public float Cuenta_Destino { get; set; }
        public float Canal { get; set; }
}
}
