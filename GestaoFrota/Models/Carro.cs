using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrota.Models
{
    // Aqui usarei construtores primários
    public class Carro( string placa, string modelo, int ano, decimal valorDiariaBase, int quantidadePortas) : Veiculo (placa, modelo, ano, valorDiariaBase)
    {
        public int QuantidadePortas { get; set; } = quantidadePortas;

        public override decimal CalcularCustoAluguel(int dias)
        {
            decimal custoBase = ValorDiariaBase * dias;
            return custoBase + (custoBase * 0.10m); // 10% de seguro
        }
        public override string ObterDescricao()
        {
            return $"{base.ObterDescricao()} | Portas: {QuantidadePortas}";
        }
    }
}
