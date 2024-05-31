using Application.Common.Interfaces;
using Application.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMaster.Controllers
{
    public class TicketMasterController
    {

        private readonly IEnumerable<IUseCase> _useCases;


        public TicketMasterController(IEnumerable<IUseCase> useCases)
        {
            _useCases = useCases;
        }

        public void AddTicket()
        {
            var addTicketCommand = (IAddTicketCommand)_useCases.FirstOrDefault(u => u is IAddTicketCommand);
            addTicketCommand?.Execute();
        }

    }
}
