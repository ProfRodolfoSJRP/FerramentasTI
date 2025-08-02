using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ferramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = $"Sistema Operacional:{Environment.OSVersion}\n" +
            $"Arquitetura: {(Environment.Is64BitOperatingSystem ? "64 Bits" : "32")}" +
            $"Processador: {System.Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")}";

            MessageBox.Show(info);
        }

        private void apagarArquivosTemporáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exibe uma Mensagem de Confirmação
            var result = MessageBox.Show("Certeza ? Vai que da ruim !",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // captura o caminho da pasta temporário do windows
                string tempPatch = Path.GetTempPath();
                // Rodar Metodo para apagar os arquivos que vamos criar
                DeletarArquivosTemporarios(tempPatch);
            }
        }

        private void DeletarArquivosTemporarios(string tempPatch)
        {
            // Tente deletar
            try
            {
                // se a parta Existir
                if (Directory.Exists(tempPatch))
                {
                    DirectoryInfo di = new DirectoryInfo(tempPatch);

                    // Deleta todos os arquivos encontrados
                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }

                    // Deleta todas as pastas 
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete();
                    }
                }
                else
                {
                    MessageBox.Show("A Pasta não existe !",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void desligarComputadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar uma instancia ('conexão') com o form 2
            desligaPc desliga = new desligaPc();
            desliga.ShowDialog();
        }
    }
}
