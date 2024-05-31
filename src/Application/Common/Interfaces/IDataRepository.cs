using Domain.Entities;
using Domain.Enums;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IDataRepository
    {
        DataTable GetAllTicket();
        DataTable GetTicketById(int id);
        void AddTicket(Boleto boleto);
        void UpdateTicket(Boleto boleto);
        void DeleteTicket(int id);

    }
}
