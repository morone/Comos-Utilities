using System;
using System.Windows.Forms;
using System.IO;
using Comos_Utilities.classes;


namespace Comos_Utilities
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdExecutar_Click(object sender, EventArgs e)
        {
            //Checa se o que foi digitado é diferente de vazio.
            if (txtFileName.Text != "")
            {
                /*Cria um novo objeto do tipo Arquivo, passando a extensão do arquivo em letras maiúsculas
                 * e o caminho completo.
                 * */
                Arquivo arquivo = new Arquivo(Path.GetExtension(txtFileName.Text).ToUpper(), txtFileName.Text);

                //Só funciona se o arquivo que foi inserido é CRp
                if (arquivo.Extensao == ".CRP")
                {
                    //Verifica qual opção foi selecionada.
                    if (radioCopia.Checked) arquivo.CopiarCRP(); else arquivo.ApagarLCK();
                    //Limpa a caixa de texto.
                    txtFileName.Text = "";
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            //Quando o form for carregado, preencher o path para o arquivo.
            this.PreencherCampoPath();
        }


        //Insere na caixa de texto o que estiver no clipboard.
        public void PreencherCampoPath()
        {
            //Antes de inserir, verifica se a caixa de texto está vazia e se o conteúdo do clipboard contém um '.CRP'.
            if ((txtFileName.Text == "") && (Clipboard.GetText().ToUpper().Contains(".CRP")))
                {
                    txtFileName.Text = Clipboard.GetText();
                }

        }


        //Ao clicar na caixa de texto, preencher o path para o arquivo.
        private void txtFileName_Enter(object sender, EventArgs e)
        {
            this.PreencherCampoPath();
        }
    }
}
