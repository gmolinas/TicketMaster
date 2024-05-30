using System;

namespace Domain.Entities
{
    public abstract class Boleto
    {
        public int Numero { get; set; }
        public double CostoEmbarque { get; set; }
        public DateTime Fecha { get; set; }
        public int TiempoEnDias { get; set; }

        public Boleto(int numero)
        {
            Numero = numero;
        }

        public abstract double CalcularRegreso();
        public abstract double CostoBoleto();
    }
}
