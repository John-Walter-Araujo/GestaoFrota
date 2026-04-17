using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace GestaoFrota.Models
{
    // Configrando o polimorfismo para o System.Text.Json
    [JsonDerivedType(typeof(Carro), typeDiscriminator: "carro")]
    [JsonDerivedType(typeof(Caminhao), typeDiscriminator: "caminhao")]

    public abstract class Veiculo
    {
        public Guid Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }

        private int _ano;
        public int Ano
        {
            get => _ano;
            set
            {
                if (value < 1900 || value > DateTime.Now.Year + 1)
                {
                    throw new ArgumentException("Ano do veículo inválido");
                    _ano = value;
                }
            }
        }
        public decimal ValorDiariaBase { get; set; }
        
        protected Veiculo(string placa, string modelo, int ano, decimal valorDiariaBase)
        {
            Id = Guid.NewGuid();
            Placa = placa;
            Modelo = modelo;
            Ano = ano;
            ValorDiariaBase = valorDiariaBase;
        }

        public abstract decimal CalcularCustoAluguel(int dias);
        public virtual string ObterDescricao() => $"{Modelo} ({Ano}) - Placa: {Placa}";
    }
}
