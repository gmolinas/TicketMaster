using Application.Common.Interfaces;

namespace Application.UseCase
{
    public class DeleteTicketCommand : IUseCase, IDeleteTicketCommand
    {
        private readonly IDataRepository _dataRepository;

        public DeleteTicketCommand(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public void Execute(int numero)
        {
            var ticket = _dataRepository.GetTicketById(numero);
            if (ticket.Rows.Count == 0)
                return;

            _dataRepository.DeleteTicket(numero);
        }
    }
}
