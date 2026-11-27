using BackUrbanPark.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUrbanPark
{
    public partial class frmRegistrarEntrada : Form
    {
        private string _numVaga;
        private int _idVaga;

        public frmRegistrarEntrada()
        {
            InitializeComponent();
        }

        public frmRegistrarEntrada(string numVaga, int idVaga)
        {
            _numVaga = numVaga;
            _idVaga = idVaga;
        }

        private void frmRegistrarEntrada_Load(object sender, EventArgs e)
        {
            txtVagaSelecionada.Text = _numVaga;
            txtVagaSelecionada.Enabled = false;
        }

        private void btnBuscarPorPlaca_click(object sender, EventArgs e)
        {
            DadosEntradaVeiculo? dadosVeículo = new DadosEntradaVeiculo();
            dadosVeículo = EntradaRepository.(mskPlacaveiculo.Texto);

            if ( dadosVeículo == null)
            {
                MessageBox.Show("Veículo não encontrado",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
                return;
            }
            txtNomeCliente.Text = grpDadosVeiculo
        }
    }
}
