using System;
using System.Windows.Forms;
using System.IO;
using Comos_Utilities.classes;


namespace Comos_Utilities
{
    public partial class frmMain : Form
    {
        public Arquivo arquivo;

        public frmMain()
        {
            InitializeComponent();
        }


        private void cmdExecutar_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != "")
            {
                arquivo = new Arquivo(Path.GetExtension(txtFileName.Text).ToUpper(), txtFileName.Text);

                if ((arquivo.Existe) && (arquivo.Extensao == ".CRP"))
                {
                    if (radioCopia.Checked) arquivo.CopiarCRP(); else arquivo.ApagarLCK();
                    txtFileName.Text = "";
                }
                else
                {
                    MessageBox.Show("Arquivo CRp não encontrado!", "Erro");
                }
            }
        }
    }
}
