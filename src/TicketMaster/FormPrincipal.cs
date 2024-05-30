using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMaster
{
    public partial class FormPrincipal : Form
    {
        private List<Boleto> boletosVendidos;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
    public abstract class Boleto
    {
        public int Numero { get; set; }
        public double CostoEmbarque { get; set; }
        public DateTime Fecha { get; set; }
        public int TiempoEnDias { get; set; }

        public Boleto(int numero)
        {
            Numero = numero;
        }

        public abstract double CalcularRegreso();
        public abstract double CostoBoleto();
    }

    public class Turista : Boleto
    {
        public Turista(int numero) : base(numero) { }

        public override double CalcularRegreso()
        {
            return 0; // Implementar lógica
        }

        public override double CostoBoleto()
        {
            return CostoEmbarque; // Implementar lógica
        }
    }

    public class Ejecutivo : Boleto
    {
        public Ejecutivo(int numero) : base(numero) { }

        public override double CalcularRegreso()
        {
            return 0; // Implementar lógica
        }

        public override double CostoBoleto()
        {
            return CostoEmbarque; // Implementar lógica
        }
    }

    public enum TipoBoleto
    {
        Todos,
        Turista,
        Ejecutivo
    }
}
