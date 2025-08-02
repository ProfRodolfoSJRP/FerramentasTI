using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferramentas
{
    public partial class desligaPc : Form
    {
        public desligaPc()
        {
            InitializeComponent();
        }

        private void btnEscolhaH_Click(object sender, EventArgs e)
        {
            // Obtem o horário selecionado pelo usuário
            DateTime horarioDesligamengo = dateTimePicker1.Value;
            // Obtem a hora atual
            DateTime agora = DateTime.Now;

            // Calcula o tempo restante até o horário especifico 
            TimeSpan tempoRestante = horarioDesligamengo - agora;

            // Converte o tempo para segundos
            int tempoRestanteSegundos = (int)tempoRestante.TotalSeconds;

            // Executa o comando para desligar 
            Process.Start(new ProcessStartInfo(
                "shutdown", $"/s /t {tempoRestanteSegundos}")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
            });

          MessageBox.Show($"Seu pc vai de berço as {horarioDesligamengo}");
        }

        private void btnCancelaDesligamento_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(
            "shutdown", $"/a")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
            });
            MessageBox.Show("Desligamento Cancelado");
        }
    }
}
