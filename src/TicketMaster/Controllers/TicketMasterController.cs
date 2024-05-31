using Application.Common.Interfaces;
using Application.UseCase;
using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMaster.Controllers
{
    public class TicketMasterController
    {

        private readonly IEnumerable<IUseCase> _useCases;


        public TicketMasterController(IEnumerable<IUseCase> useCases)
        {
            _useCases = useCases;
        }

        public void AddTicket(string totalDeDias, string fechaDeSalida, string costeEnbarque, string tipoBoleto)
        {
            if (!int.TryParse(totalDeDias, out int td))
            {
                MessageBox.Show("El total de dias debe ser un numero entero");
                return;
            }
            if (!double.TryParse(costeEnbarque, out double ce) || ce < Constants.BoletoCostoBase)
            {
                MessageBox.Show($"El costo de embarque debe ser un numero y de base {Constants.BoletoCostoBase}");
                return;
            }
            if (!DateTime.TryParse(fechaDeSalida, out DateTime fs))
            {
                MessageBox.Show("La fecha de salida debe ser una fecha valida");
                return;
            }
            if (!Enum.TryParse<TipoBoleto>(tipoBoleto, out TipoBoleto tb))
            {
                MessageBox.Show("El tipo de boleto no es valido");
                return;
            }

            var addTicketCommand = (IAddTicketCommand)_useCases.FirstOrDefault(u => u is IAddTicketCommand);
            addTicketCommand?.Execute(td, ce, fs, tb);
        }

        public DataTable GetTicket()
        {
            var addTicketCommand = (IGetTicketCommand)_useCases.FirstOrDefault(u => u is IGetTicketCommand);
            return addTicketCommand?.Execute();
        }
        public DataTable GetTicket(string numero)
        {
            var addTicketCommand = (IGetTicketCommand)_useCases.FirstOrDefault(u => u is IGetTicketCommand);
            //try to parse the string to int
            if (!int.TryParse(numero, out int num))
            {
                return addTicketCommand?.Execute();
            }
            return addTicketCommand?.Execute(num);
        }

    }
}
