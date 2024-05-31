using Application.Common.Interfaces;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Infrastructure.Repositories
{
    public class SqlDataRepository : IDataRepository
    {
        private readonly string _connectionString;

        public SqlDataRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private DataTable ExecuteQuery(string query)
        {
             using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    connection.Open();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public  DataTable GetAllTicket()
        {
            //cambiar la columna de TipoBoletoId por tipoBoleto y hacer un join con la tabla TipoBoleto
            var query = "SELECT  B.Numero, B.CostoEmbarque, B.FechaSalida, B.TiempoEnDias, B.FechaRegreso, T.Descripcion AS TipoBoletoDescripcion FROM Boleto B JOIN TipoBoleto T ON B.TipoBoletoId = T.Tipo;";

            return ExecuteQuery(query);
        }

        public DataTable GetTicketById(int id)
        {
            var query = $"SELECT  B.Numero, B.CostoEmbarque, B.FechaSalida, B.TiempoEnDias, B.FechaRegreso, T.Descripcion AS TipoBoletoDescripcion FROM Boleto B JOIN TipoBoleto T ON B.TipoBoletoId = T.Tipo WHERE  B.Numero = {id};";
            return ExecuteQuery(query);
        }

        public void AddTicket( double ShippingCost, DateTime DepartDate, int TimeInDays )
        {
            DateTime dateTime = DateTime.Now;
            string formattedDateTime = dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            var query = $"INSERT INTO Boleto ( CostoEmbarque, FechaSalida, TiempoEnDias) VALUES ({ShippingCost}, '{formattedDateTime}', '{TimeInDays}')";
            ExecuteNonQuery(query);
        }

        public void UpdateTicket(int number, double ShippingCost, DateTime DepartDate, int TimeInDays)
        {
            string formattedDateTime = DepartDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            var query = $"UPDATE Boleto SET CostoEmbarque = {ShippingCost}, FechaSalida = '{formattedDateTime}', TiempoEnDias = '{TimeInDays}' WHERE Numero = {number}";
            ExecuteNonQuery(query);
        }

        public void DeleteTicket(int id)
        {
            var query = $"DELETE FROM Boleto WHERE Id = {id}";
            ExecuteNonQuery(query);
        }
    }
}
