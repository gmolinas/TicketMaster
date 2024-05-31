using System;

namespace Domain.Entities
{
    public abstract class Boleto
    {
        public double CostoEmbarque { get; set; }
        public DateTime FechaSalida { get; set; }
        public int Numero { get; set; }
        public int TiempoEnDias { get; set; }

        public Boleto(int numero)
        {
            Numero = numero;
        }

        public abstract DateTime CalcularRegreso();
        public abstract double CostoBoleto();
    }
}
