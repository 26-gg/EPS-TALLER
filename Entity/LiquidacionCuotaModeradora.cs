using System;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora
    {
        public int NumeroLiquidacion { get; set; }
        public string IdentificacionPaciente { get; set; }
        public string TipoAfiliado { get; set; }
        public decimal SalarioDevengado { get; set; }
        public decimal ValorServicioPrestado { get; set; }
        public decimal Cuota { get; set; }

        public abstract decimal CalcularCuota();
    }
}
