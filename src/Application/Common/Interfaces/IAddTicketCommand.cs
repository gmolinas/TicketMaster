using Domain.Enums;
using System;

namespace Application.Common.Interfaces
{
    public interface IAddTicketCommand
    {
        void Execute(int totalDeDias, double costeEmbarque, DateTime fechaDeSalida, TipoBoleto tipoBoleto);
    }
}
