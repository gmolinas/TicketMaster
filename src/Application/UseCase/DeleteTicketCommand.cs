using Application.Common.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
