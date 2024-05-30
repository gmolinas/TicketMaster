using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public class Venta
    {
        public DateTime FechaVenta { get; set; }
        public List<Boleto> BoletosVendidos { get; set; } = new List<Boleto>();

        public bool Actualizar(Boleto unBoleto)
        {
            var boletoExistente = BoletosVendidos.FirstOrDefault(b => b.Numero == unBoleto.Numero);
            if (boletoExistente != null)
            {
                BoletosVendidos.Remove(boletoExistente);
                BoletosVendidos.Add(unBoleto);
                return true;
            }
            return false;
        }

        public bool Agregar(Boleto unBoleto)
        {
            BoletosVendidos.Add(unBoleto);
            return true;
        }

        public Boleto Buscar(int numeroBoleto)
        {
            return BoletosVendidos.FirstOrDefault(b => b.Numero == numeroBoleto);
        }

        public bool Eliminar(int numeroBoleto)
        {
            var boleto = Buscar(numeroBoleto);
            if (boleto != null)
            {
                BoletosVendidos.Remove(boleto);
                return true;
            }
            return false;
        }

        public List<Boleto> ListarTodos()
        {
            return BoletosVendidos;
        }
    }
}
