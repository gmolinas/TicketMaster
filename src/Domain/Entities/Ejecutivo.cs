using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Ejecutivo : Boleto
    {
        public Ejecutivo(int numero) : base(numero) { }

        public override DateTime CalcularRegreso()
        {
            return FechaSalida.AddDays(TiempoEnDias); 
        }

        public override double CostoBoleto()
        {
            return CostoEmbarque + Constants.IncrementaCostoEjecutivo;
        }
    }
}
