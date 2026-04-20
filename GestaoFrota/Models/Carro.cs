using System.Numerics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestaoFrota.Models
{
    // Uso de Construtores Primários (Primary Constructors)
    public class Carro(string placa, string modelo, int ano,
   decimal valorDiariaBase, int quantidadePortas)
    : Veiculo(placa, modelo, ano, valorDiariaBase)
    {
        public int QuantidadePortas { get; set; } =
       quantidadePortas;

        public override decimal CalcularCustoAluguel(int dias)
        {
            decimal custoBase = ValorDiariaBase * dias;
            return custoBase + (custoBase * 0.10m); // 10% de seguro
        }

        public override string ObterDescricao() =>
       $"{base.ObterDescricao()} | Portas: {QuantidadePortas}";
    }
}