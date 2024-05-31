using Application.Common.Interfaces;
using Domain.Dtos;
using Domain.Entities;
using FastMember;
using System.Collections.Generic;
using System.Data;


namespace Infrastructure.Repositories
{
    public class MemoryDataRepository : IDataRepository
    {
        private readonly Venta _venta;
        private readonly List<Boleto> _boletos;

        public MemoryDataRepository()
        {
            _boletos = new List<Boleto>();
            _venta = new Venta(_boletos);
        }

        public void AddTicket(Boleto boleto)
        {
            _venta.Agregar(boleto);
        }

        public void DeleteTicket(int id)
        {
            _venta.Eliminar(id);
        }

        public DataTable GetAllTicket()
        {
            var boletos = _venta.ListarTodos();
            List<BoletoResponseDto> responseDtos = new List<BoletoResponseDto>();

            foreach (var boleto in boletos)
            {
                var tipoBoleto = boleto.GetType();
                boleto.Numero = boletos.IndexOf(boleto) + 1;
                BoletoResponseDto boletoResponse = new BoletoResponseDto()
                {
                    Numero = boleto.Numero,
                    CostoEmbarque = boleto.CostoBoleto(),
                    FechaSalida = boleto.FechaSalida,
                    FechaRegreso = boleto.CalcularRegreso(),
                    TiempoEnDias = boleto.TiempoEnDias,
                    TipoBoleto = tipoBoleto.Name
                };
                responseDtos.Add(boletoResponse);
            }


            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(responseDtos))
            {
                table.Load(reader);
            }
            return table;
        }

        public DataTable GetTicketById(int id)
        {
            var boleto = _venta.Buscar(id);
            DataTable table = new DataTable();
            if (boleto == null)
                return GetAllTicket();

            var tipoBoleto = boleto.GetType();
            boleto.Numero = id;
            BoletoResponseDto boletoResponse = new BoletoResponseDto()
            {
                Numero = boleto.Numero,
                CostoEmbarque = boleto.CostoBoleto(),
                FechaSalida = boleto.FechaSalida,
                FechaRegreso = boleto.CalcularRegreso(),
                TiempoEnDias = boleto.TiempoEnDias,
                TipoBoleto = tipoBoleto.Name
            };

            table.Columns.Add("Numero");
            table.Columns.Add("CostoEmbarque");
            table.Columns.Add("FechaSalida");
            table.Columns.Add("FechaRegreso");
            table.Columns.Add("TiempoEnDias");
            table.Columns.Add("TipoBoleto");

            DataRow row = table.NewRow();
            row["Numero"] = boletoResponse.Numero;
            row["CostoEmbarque"] = boletoResponse.CostoEmbarque;
            row["FechaSalida"] = boletoResponse.FechaSalida;
            row["FechaRegreso"] = boletoResponse.FechaRegreso;
            row["TiempoEnDias"] = boletoResponse.TiempoEnDias;
            row["TipoBoleto"] = boletoResponse.TipoBoleto;
            table.Rows.Add(row);

            return table;
        }

        public void UpdateTicket(Boleto boleto)
        {
            _venta.Actualizar(boleto);
        }
    }
}
