using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Turista : Boleto
    {
        public Turista(int numero) : base(numero) { }

        public override DateTime CalcularRegreso()
        {
            return FechaSalida.AddDays(TiempoEnDias);
        }

        public override double CostoBoleto()
        {
            return CostoEmbarque + Constants.IncrementaCostoTurista;
        }
    }
}
