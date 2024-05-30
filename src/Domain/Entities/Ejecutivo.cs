namespace Domain.Entities
{
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
}
