using Application.Common.Interfaces;
using Domain.Entities;
using FastMember;
using System.Data;

namespace Application.UseCase
{
    public class GetTicketCommand : IUseCase, IGetTicketCommand
    {
        private readonly IDataRepository _dataRepository;

        public GetTicketCommand(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public DataTable Execute()
        {
            return _dataRepository.GetAllTicket();
        }

        public DataTable Execute(int numero)
        {
            return _dataRepository.GetTicketById(numero);
        }
    }
}
