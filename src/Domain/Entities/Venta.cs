using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Venta
    {
        public DateTime FechaVenta { get; set; }
        private readonly List<Boleto> boletos;

        public Venta(List<Boleto> boletosLista)
        {
            boletos = boletosLista;
        }

        public bool Actualizar(Boleto unBoleto)
        {
            var boletoExistente = Buscar(unBoleto.Numero);
            if (boletoExistente != null)
            {
                boletos.Remove(boletoExistente);
                boletos.Add(unBoleto);
                return true;
            }
            return false;
        }

        public bool Agregar(Boleto unBoleto)
        {
            boletos.Add(unBoleto);
            return true;
        }

        public Boleto Buscar(int numeroBoleto)
        {
            return boletos.Find(b => b.Numero == numeroBoleto);
        }

        public bool Eliminar(int numeroBoleto)
        {
            var boleto = Buscar(numeroBoleto);
            if (boleto != null)
            {
                boletos.Remove(boleto);
                return true;
            }
            return false;
        }

        public List<Boleto> ListarTodos()
        {
            return boletos;
        }

    }
}
