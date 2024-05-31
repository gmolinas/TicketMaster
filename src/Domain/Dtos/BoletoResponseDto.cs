using System;

namespace Domain.Dtos
{
    public class BoletoResponseDto
    {
        public int Numero { get; set; }
        public double CostoEmbarque { get; set; }
        public DateTime FechaSalida { get; set; }
        public int TiempoEnDias { get; set; }
        public DateTime FechaRegreso { get; set; }
        public string TipoBoleto { get; set; }
    }
}
