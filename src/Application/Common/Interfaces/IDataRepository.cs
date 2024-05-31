using Domain.Entities;
using System.Data;

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
