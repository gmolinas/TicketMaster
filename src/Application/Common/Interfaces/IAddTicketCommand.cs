using Domain.Enums;
using System;

namespace Application.Common.Interfaces
{
    public interface IAddTicketCommand
    {
        void Execute(int totalDeDias, double fechaDeSalida, DateTime costeEnbarque, TipoBoleto tipoBoleto);
    }
}
