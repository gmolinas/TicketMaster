using System;
using System.Data;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IDataRepository
    {
        DataTable GetAllTicket();
        DataTable GetTicketById(int id);
        void AddTicket(double ShippingCost, DateTime DepartDate, int TimeInDays);
        void UpdateTicket(int number, double ShippingCost, DateTime DepartDate, int TimeInDays);
        void DeleteTicket(int id);

    }
}
