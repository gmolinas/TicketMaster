using System;
using System.Windows.Forms;
using TicketMaster.Controllers;

namespace TicketMaster
{
    public partial class FormPrincipal : Form
    {
        private readonly TicketMasterController _controller;


        public FormPrincipal(TicketMasterController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Lógica para agregar un boleto
            _controller.AddTicket(totalDeDias.Text, fechaDeSalida.Text, costoDeEmbarque.Text, tipoDeBoleto.Text);
            RefreshDataGrid();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Lógica para buscar un boleto
            dataGridViewBoletos.DataSource = _controller.GetTicket(Numero.Text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar un boleto
            _controller.DeleteTicket(Numero.Text);
            RefreshDataGrid();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            // Lógica para listar todos los boletos
            _controller.UpdateTicket(Numero.Text,totalDeDias.Text, fechaDeSalida.Text, costoDeEmbarque.Text, tipoDeBoleto.Text);
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridViewBoletos.DataSource = _controller.GetTicket();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
    }
}
