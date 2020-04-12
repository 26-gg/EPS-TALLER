using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Contributiva : LiquidacionCuotaModeradora
    {
        const decimal SMMLV = 877800m;
        public Contributiva()
        {
            NumeroLiquidacion = NumeroLiquidacion;
            IdentificacionPaciente = IdentificacionPaciente;
            TipoAfiliado = TipoAfiliado;
            SalarioDevengado = SalarioDevengado;
            ValorServicioPrestado = ValorServicioPrestado;
        }
        public override decimal CalcularCuota()
        {
            if (SalarioDevengado < (SMMLV*2))
            {
                Cuota = ValorServicioPrestado * 0.15m;

                if (Cuota > 250000)
                {
                    Cuota = 250000;
                }
                return Cuota;
            }
            else if (SalarioDevengado >= (SMMLV*2) && SalarioDevengado < (SMMLV*5))
            {
                Cuota = ValorServicioPrestado * 0.2m;
                if (Cuota > 900000)
                {
                    Cuota = 900000;
                }
                return Cuota;
            }
            else
            {
                Cuota = ValorServicioPrestado * 0.25m;
                if (Cuota > 1500000)
                {
                    Cuota = 1500000;
                }
                return Cuota;
            }
        }

        public override string ToString()
        {
            return $"La cuota moderadora numero {NumeroLiquidacion} se le registro al paciente  con ID {IdentificacionPaciente} su cuota es de {Cuota} para un salario de {SalarioDevengado}";
        }
    }
}
