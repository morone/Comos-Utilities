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
        //Objeto do tipo FolderBrowserDialog para poder abrir a janela de seleção de diretório
        private FolderBrowserDialog f = new FolderBrowserDialog();
        //Extensão do Arquivo Eletrônico.
        public String Extensao;
        //Caminho completo até o arquivo (digitado pelo user).
        public String Caminho;

        public Arquivo(String Extensao, String CaminhoArquivo)
        {
            this.Extensao = Extensao;
            this.Caminho = CaminhoArquivo;
        }


        public void ApagarLCK()
        {
            //Como é um arquivo LCK, esta linha abaixo troca a extensão do arquivo digitado.
            this.Caminho = this.Caminho.Substring(0, this.Caminho.Length - 3) + "lck";

            //Se o arquivo existir.
            if (File.Exists(this.Caminho))
            {
                try
                {
                    //Deleta o arquivo
                    File.Delete(this.Caminho);
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
            //Se o arquivo existir.
            if (File.Exists(this.Caminho))
            {
                //Abre a janela para o usuário selecionar um diretório e verifica se ele clicou em OK.
                if (this.f.ShowDialog() == DialogResult.OK)
                {
                    //Faz uma concatenação entre o diretório que o usuário selecionou e o nome do arquivo que ele vai copiar.
                    String destFile = System.IO.Path.Combine(this.f.SelectedPath, Path.GetFileName(this.Caminho));
                    //Copia o arquivo.
                    File.Copy(this.Caminho, destFile);
                    MessageBox.Show("Arquivo Copiado! Pague um café para o Ádamo!", "Copiar CRp");
                }
            }
            else
            {
                MessageBox.Show("Arquivo CRp não encontrado!", "Erro");
            }
        }
    }
}
