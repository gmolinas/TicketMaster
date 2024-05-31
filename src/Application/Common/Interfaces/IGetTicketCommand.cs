using System.Data;

namespace Application.Common.Interfaces
{
    public interface IGetTicketCommand
    {
        DataTable Execute();
        DataTable Execute(int numero);
    }
}
