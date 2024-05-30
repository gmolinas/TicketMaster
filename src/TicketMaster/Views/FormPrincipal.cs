using Application.Common.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicketMaster
{
    public partial class FormPrincipal : Form
    {

        private readonly IDataRepository _repository;

        public FormPrincipal(IDataRepository repository)
        {
            repository = _repository;
            InitializeComponent();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            // Lógica para añadir un boleto
            MessageBox.Show("Añadir boleto no implementado.");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Lógica para actualizar un boleto
            MessageBox.Show("Actualizar boleto no implementado.");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Lógica para buscar un boleto
            MessageBox.Show("Buscar boleto no implementado.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar un boleto
            MessageBox.Show("Eliminar boleto no implementado.");
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            // Lógica para listar todos los boletos
            MessageBox.Show("Listar boletos no implementado.");
        }
    }
}
