using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Subsidiado : LiquidacionCuotaModeradora
    {
        public Subsidiado()
        {
            NumeroLiquidacion = NumeroLiquidacion;
            IdentificacionPaciente = IdentificacionPaciente;
            TipoAfiliado = TipoAfiliado;
            SalarioDevengado = SalarioDevengado;
            ValorServicioPrestado = ValorServicioPrestado;
        }
        public override decimal CalcularCuota()
        {
            Cuota = ValorServicioPrestado * 0.05m;
            if (Cuota > 200000)
            {
                Cuota = 200000;
            }
            return Cuota;
        }

        public override string ToString()
        {
            return $"La cuota moderadora numero {NumeroLiquidacion} se le registro al paciente  con ID {IdentificacionPaciente} su cuota es de {Cuota}";
        }
    }
}
