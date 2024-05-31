using Domain.Enums;
using System;

namespace Application.Common.Interfaces
{
    public interface IUpdateTicketCommand
    {
        void Execute(int numero, int totalDeDias, double costeEmbarque, DateTime fechaDeSalida, TipoBoleto tipoBoleto);
    }
}
