using BackUrbanPark.Model;
using BackUrbanPark.Repository;
using frmUrbanPark.Parts;
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
    public partial class frmListVagas : Form
    {
        public frmListVagas()
        {
            InitializeComponent();
        }

        private void frmListVagas_Load(object sender, EventArgs e)
        {
            flwCardVagas.Controls.Clear();

            //Instanciar um novo CardVagas

            ctrStatusVagas cardVaga = new ctrStatusVagas();
            cardVaga.StatusVaga = StatusVaga.Ocupada;
            cardVaga.NumeroVaga = 99.ToString();

            flwCardVagas.Controls.Add(cardVaga);
           

        }

        private void carregarDadosEMontarVisualizacao()
        {

            List<Vaga> listaDevagas = VagaRepository.BuscarTodos();

            flwCardVagas.Controls.Clear();

            foreach (Vaga vaga in listaDevagas)
            {
                string strNumeroVaga = vaga.Numero_vaga.ToString();
                StatusVaga statusVaga = Enum.Parse<StatusVaga>(vaga.Status.ToString());

                int idVaga = vaga.Id;

                ctrStatusVagas cardVaga = new ctrStatusVagas();
                cardVaga.IdVaga = idVaga;
                cardVaga.StatusVaga = statusVaga;
                cardVaga.NumeroVaga = strNumeroVaga;

                flwCardVagas.Controls.Add(cardVaga);
            }
        }
    }
}
