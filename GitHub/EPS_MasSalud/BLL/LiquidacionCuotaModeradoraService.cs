using System;
using Entity;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class LiquidacionCuotaModeradoraService
    {
        LiquidacionCuotaModeradoraRepository repository = new LiquidacionCuotaModeradoraRepository();

        public string Registrar(LiquidacionCuotaModeradora cuota)
        {
            if (repository.Buscar(cuota.NumeroLiquidacion) == null)
            {
                repository.Registra(cuota);
                return $"La cuota se registro con exito con el numero {cuota.NumeroLiquidacion} ";
            }
            return $"La cuota no se pudo registrar por que ya existe una con el mismo numero ";
        }

        public List<LiquidacionCuotaModeradora> Consultar()
        {
            return repository.Consultar();
        }

        public LiquidacionCuotaModeradora CrearCuota(string tipo)
        {
            if (tipo == "Subsidiado")
            {
                LiquidacionCuotaModeradora liquidacion = new Subsidiado();
                return liquidacion;
            }
            else
            {
                LiquidacionCuotaModeradora liquidacion = new Contributiva();
                return liquidacion;
            }          
        }

        public string Eliminar(int numero)
        {
            if (repository.Buscar(numero) == null)
            {
                return $"La cuota con numero {numero} no existe";
            }
            else
            {
                repository.Eliminar(numero);
                return $"La cuota con numero {numero} se ha eliminado con exito";
            }
        }
    }
}
