using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncidenteCreator
{
    public partial class IncidenteCreator : Form
    {
        public IncidenteCreator()
        {   
            InitializeComponent();
        }

        private void btnGerarInc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumero.Text))
            {  
                var incidente = new Incidente()
                {
                    numero = txtNumero.Text.TrimEnd(),
                    resumo = txtResumo.Text,
                    solicitante = txtSolicitatante.Text,
                    descricao = txtDescricao.Text
                };

                var gerador = new Gerador();

                var incidenteCompleto = gerador.CriarPastasIncidente(incidente);

                gerador.CriarTemplate(incidenteCompleto);
                gerador.CriarConsultas(incidenteCompleto);

                lbOcorrencia.Text = "Pasta Criada!";
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtNumero.Text = string.Empty;
            txtResumo.Text = string.Empty;
            txtSolicitatante.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

        private void TxtNumero_Enter(object sender, EventArgs e)
        {
            lbOcorrencia.Text = "";
        }
    }
}
