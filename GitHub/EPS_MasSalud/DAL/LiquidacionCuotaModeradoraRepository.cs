using System;
using System.Collections.Generic;
using Entity;

namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {
        List<LiquidacionCuotaModeradora> lista = new List<LiquidacionCuotaModeradora>();
        public void Registra(LiquidacionCuotaModeradora cuota)
        {
            lista.Add(cuota);
        }

        public List<LiquidacionCuotaModeradora> Consultar()
        {
            return lista;
        }

        public LiquidacionCuotaModeradora Buscar(int numero)
        {
            foreach (var item in lista)
            {
                if (item.NumeroLiquidacion.Equals(numero))
                {
                    return item;
                }
            }
            return null;
        }

        public void Eliminar(int numero)
        {
            lista = Consultar();
            foreach (var item in lista.ToArray())
            {
                if (numero.Equals(item.NumeroLiquidacion))
                {
                    lista.Remove(item);
                }
            }
        }
    }
}
