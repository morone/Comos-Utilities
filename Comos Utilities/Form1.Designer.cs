namespace Comos_Utilities
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.radioCopia = new System.Windows.Forms.RadioButton();
            this.radioLck = new System.Windows.Forms.RadioButton();
            this.cmdExecutar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.radioCopia);
            this.groupBox1.Controls.Add(this.radioLck);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cole abaixo o caminho do arquivo CRp!";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(7, 68);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(408, 20);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.Enter += new System.EventHandler(this.txtFileName_Enter);
            // 
            // radioCopia
            // 
            this.radioCopia.AutoSize = true;
            this.radioCopia.Location = new System.Drawing.Point(97, 20);
            this.radioCopia.Name = "radioCopia";
            this.radioCopia.Size = new System.Drawing.Size(79, 17);
            this.radioCopia.TabIndex = 1;
            this.radioCopia.TabStop = true;
            this.radioCopia.Text = "Copiar CRp";
            this.radioCopia.UseVisualStyleBackColor = true;
            // 
            // radioLck
            // 
            this.radioLck.AutoSize = true;
            this.radioLck.Location = new System.Drawing.Point(7, 20);
            this.radioLck.Name = "radioLck";
            this.radioLck.Size = new System.Drawing.Size(79, 17);
            this.radioLck.TabIndex = 0;
            this.radioLck.TabStop = true;
            this.radioLck.Text = "Excluir LCK";
            this.radioLck.UseVisualStyleBackColor = true;
            // 
            // cmdExecutar
            // 
            this.cmdExecutar.Location = new System.Drawing.Point(333, 137);
            this.cmdExecutar.Name = "cmdExecutar";
            this.cmdExecutar.Size = new System.Drawing.Size(104, 35);
            this.cmdExecutar.TabIndex = 1;
            this.cmdExecutar.Text = "&Executar";
            this.cmdExecutar.UseVisualStyleBackColor = true;
            this.cmdExecutar.Click += new System.EventHandler(this.cmdExecutar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 184);
            this.Controls.Add(this.cmdExecutar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 218);
            this.MinimumSize = new System.Drawing.Size(460, 218);
            this.Name = "frmMain";
            this.Text = "Comos Utilities";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.RadioButton radioCopia;
        private System.Windows.Forms.RadioButton radioLck;
        private System.Windows.Forms.Button cmdExecutar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

