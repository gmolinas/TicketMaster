using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;


namespace Application.UseCase
{
    public class AddTicketCommand : IUseCase, IAddTicketCommand
    {
        private readonly IDataRepository _dataRepository;

        public AddTicketCommand(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public void Execute(int totalDeDias, double costeEmbarque, DateTime fechaDeSalida, TipoBoleto tipoBoleto)
        {
            Boleto boleto;
            switch (tipoBoleto)
            {
                case TipoBoleto.Ejecutivo:
                    boleto = new Ejecutivo(0)
                    {
                        TiempoEnDias = totalDeDias,
                        CostoEmbarque = costeEmbarque,
                        FechaSalida = fechaDeSalida
                    };
                    break;
                case TipoBoleto.Turista:
                    boleto = new Turista(0)
                    {
                        TiempoEnDias = totalDeDias,
                        CostoEmbarque = costeEmbarque,
                        FechaSalida = fechaDeSalida
                    };
                    break;
                default:
                    throw new ArgumentException("Tipo de boleto no válido.");
            }

            _dataRepository.AddTicket(boleto);
        }
    }
}
