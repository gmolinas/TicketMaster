using System.Data;

namespace Application.Common.Interfaces
{
    public interface IDataRepository
    {
        DataTable ExecuteQuery(string query);
        void ExecuteNonQuery(string query);
    }
}
