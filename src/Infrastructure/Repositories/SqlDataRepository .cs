using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Data;
using System.Data.SqlClient;

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

        public DataTable GetAllTicket()
        {
            var query = "SELECT  B.Numero, B.CostoEmbarque, B.FechaSalida, B.TiempoEnDias, B.FechaRegreso, T.Descripcion AS TipoBoleto FROM Boleto B JOIN TipoBoleto T ON B.TipoBoletoId = T.Tipo;";
            return ExecuteQuery(query);
        }

        public DataTable GetTicketById(int id)
        {
            var query = $"SELECT  B.Numero, B.CostoEmbarque, B.FechaSalida, B.TiempoEnDias, B.FechaRegreso, T.Descripcion AS TipoBoleto FROM Boleto B JOIN TipoBoleto T ON B.TipoBoletoId = T.Tipo WHERE  B.Numero = {id};";
            return ExecuteQuery(query);
        }

        public void AddTicket(Boleto boleto)
        {
            var tipoBoleto = boleto.GetType();
            TipoBoleto enumValue = (TipoBoleto)Enum.Parse(typeof(TipoBoleto), tipoBoleto.Name);
            int numberTipoBoleto = (int)enumValue;
            var query = $"INSERT INTO Boleto ( CostoEmbarque, FechaSalida, TiempoEnDias, FechaRegreso, TipoBoletoId) VALUES (" +
                $"{boleto.CostoBoleto()}," +
                $" '{boleto.FechaSalida.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
                $" '{boleto.TiempoEnDias}'," +
                $" '{boleto.CalcularRegreso().ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
                $" '{numberTipoBoleto}')";
            ExecuteNonQuery(query);
        }

        public void UpdateTicket(Boleto boleto)
        {
            var tipoBoleto = boleto.GetType();
            TipoBoleto enumValue = (TipoBoleto)Enum.Parse(typeof(TipoBoleto), tipoBoleto.Name);
            int numberTipoBoleto = (int)enumValue;
            var query = $"UPDATE Boleto SET CostoEmbarque = {boleto.CostoBoleto()}" +
                $", FechaSalida = '{boleto.FechaSalida.ToString("yyyy-MM-dd HH:mm:ss.fff")}'" +
                $", TiempoEnDias = '{boleto.TiempoEnDias}'" +
                $", FechaRegreso = '{boleto.CalcularRegreso().ToString("yyyy-MM-dd HH:mm:ss.fff")}'" +
                $", TipoBoletoId = '{numberTipoBoleto}'  WHERE Numero = {boleto.Numero}";
            ExecuteNonQuery(query);
        }

        public void DeleteTicket(int id)
        {
            var query = $"DELETE FROM Boleto WHERE Numero = {id}";
            ExecuteNonQuery(query);
        }
    }
}
