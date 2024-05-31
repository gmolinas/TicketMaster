using Application.Common.Interfaces;
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

        public void Execute(int totalDeDias, double fechaDeSalida, DateTime costeEnbarque, TipoBoleto tipoBoleto)
        {
            _dataRepository.AddTicket(200, DateTime.Now, 10);
        }
    }
}
