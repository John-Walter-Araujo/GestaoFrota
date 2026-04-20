using GestaoFrota.Models;


using System;

using System.Linq;

using System.Windows.Forms;
namespace GestaoFrota
{
    public partial class Form1 : Form
    {
        private FrotaRepository _repositorio;
        private BindingSource _bindingSource;

        public Form1()
        {
            InitializeComponent();

            _repositorio = new FrotaRepository();
            _bindingSource = new BindingSource();

            ConfigurarFormulario();
            CarregarDados();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Gestão de Frota";
            this.Size = new System.Drawing.Size(800, 600);

            // Expressões de coleção para inicializar arrays rapidamente
            cmbTipoVeiculo.Items.AddRange(["Carro", "Caminhão"]);
            cmbTipoVeiculo.SelectedIndex = 0;
            cmbTipoVeiculo.SelectedIndexChanged +=
            CmbTipoVeiculo_SelectedIndexChanged;

            btnAdcionar.Click += BtnAdicionar_Click;
            btnRemover.Click += BtnRemover_Click;

            dgvFrota.DataSource = _bindingSource;
            dgvFrota.SelectionMode =
           DataGridViewSelectionMode.FullRowSelect;
            dgvFrota.ReadOnly = true;
        }

        private void CmbTipoVeiculo_SelectedIndexChanged(object?
       sender, EventArgs e)
        {
            lblEspecifico.Text =
           cmbTipoVeiculo.SelectedItem?.ToString() == "Carro"? "Qtd. Portas:": "Capacidade Carga (Kg):";
        }


        private void CarregarDados()
        {
            var veiculos = _repositorio.ObterTodos();
            _bindingSource.DataSource = veiculos.ToList();
            _bindingSource.ResetBindings(false);
        }

        private void BtnAdicionar_Click(object? sender, EventArgs
       e)
        {
            try
            {
                string placa = txtPlaca.Text;
                string modelo = txtModelo.Text;
                int ano = int.Parse(txtAno.Text);
                decimal diaria =
               decimal.Parse(txtValorDiaria.Text);

                Veiculo novoVeiculo;

                if (cmbTipoVeiculo.SelectedItem?.ToString() ==
               "Carro")
                {
                    int portas = int.Parse(txtEspecifico.Text);
                    novoVeiculo = new Carro(placa, modelo, ano,
                   diaria, portas);
                }
                else
                {
                    double carga =
                   double.Parse(txtEspecifico.Text);
                    novoVeiculo = new Caminhao(placa, modelo,
                   ano, diaria, carga);
                }


                _repositorio.Adicionar(novoVeiculo);
                CarregarDados();
                LimparCampos();

                MessageBox.Show($"Veículo adicionado! Custo p/ 5dias: { novoVeiculo.CalcularCustoAluguel(5):C} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemover_Click(object? sender, EventArgs
       e)
        {
            if (dgvFrota.CurrentRow?.DataBoundItem is Veiculo
           veiculoSelecionado)
            {
                _repositorio.Remover(veiculoSelecionado.Id);
                CarregarDados();
            }
            else
            {
                MessageBox.Show("Selecione um veículo pararemover.");
            }
        }

        private void LimparCampos()
        {
            txtPlaca.Clear(); txtModelo.Clear(); txtAno.Clear();
            txtValorDiaria.Clear(); txtEspecifico.Clear();
            txtPlaca.Focus();
        }

    }
}