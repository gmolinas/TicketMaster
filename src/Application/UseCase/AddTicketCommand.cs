using Application.Common.Interfaces;
using System;


namespace Application.UseCase
{
    public class AddTicketCommand : IUseCase, IAddTicketCommand
    {
        public AddTicketCommand()
        {
            
        }

        public void Execute()
        {
            Console.WriteLine("AddTicketCommand executed");
        }
    }
}
