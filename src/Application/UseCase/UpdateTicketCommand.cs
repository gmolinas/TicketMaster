using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;

namespace Application.UseCase
{
    public class UpdateTicketCommand : IUseCase, IUpdateTicketCommand
    {
        private readonly IDataRepository _dataRepository;

        public UpdateTicketCommand(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public void Execute(int numero, int totalDeDias, double costeEmbarque, DateTime fechaDeSalida, TipoBoleto tipoBoleto)
        {
            var ticket = _dataRepository.GetTicketById(numero);
            if (ticket.Rows.Count == 0)
                return;

            Boleto boleto;
            switch (tipoBoleto)
            {
                case TipoBoleto.Ejecutivo:
                    boleto = new Ejecutivo(numero)
                    {
                        TiempoEnDias = totalDeDias,
                        CostoEmbarque = costeEmbarque,
                        FechaSalida = fechaDeSalida
                    };
                    break;
                case TipoBoleto.Turista:
                    boleto = new Turista(numero)
                    {
                        TiempoEnDias = totalDeDias,
                        CostoEmbarque = costeEmbarque,
                        FechaSalida = fechaDeSalida
                    };
                    break;
                default:
                    throw new ArgumentException("Tipo de boleto no válido.");
            }

            _dataRepository.UpdateTicket(boleto);
        }
    }
}
