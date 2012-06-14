using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Comos_Utilities.classes
{
    class Arquivo
    {

        private FolderBrowserDialog f = new FolderBrowserDialog();

        public String Extensao;
        public String Caminho;
        public Boolean Existe;


        public Arquivo(String Extensao, String CaminhoArquivo)
        {
            this.Extensao = Extensao;
            this.Caminho = CaminhoArquivo;
            this.Existe = File.Exists(CaminhoArquivo);
        }


        public void ApagarLCK()
        {
            String nomeArquivo = this.Caminho.Substring(0, this.Caminho.Length - 3) + "lck";

            if (File.Exists(nomeArquivo))
            {
                try
                {
                    File.Delete(nomeArquivo);
                    MessageBox.Show("LCK apagado! Pague um café para o Ádamo!", "Apagar LCK");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Problema ao apagar arquivo! =>" + e.Data, "Erro");
                }

            }
            else
            {
                MessageBox.Show("Arquivo LCK não encontrado!", "Erro");
            }


        }

        public void CopiarCRP()
        {
            if (this.f.ShowDialog() == DialogResult.OK)
            {
                String destFile = System.IO.Path.Combine(this.f.SelectedPath, Path.GetFileName(this.Caminho));
                File.Copy(this.Caminho, destFile);
                MessageBox.Show("Arquivo Copiado! Pague um café para o Ádamo!", "Copiar CRp");
            }
        }
    }
}
