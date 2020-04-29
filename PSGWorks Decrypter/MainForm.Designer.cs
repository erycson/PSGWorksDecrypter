namespace PSGWorksDecrypter
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fbdSourceFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnSourceFolder = new System.Windows.Forms.Button();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.btnDestinationFolder = new System.Windows.Forms.Button();
            this.fbdDestinationFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnConvert = new System.Windows.Forms.Button();
            this.pbProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.bwConverter = new System.ComponentModel.BackgroundWorker();
            this.lblTotalSourceFiles = new System.Windows.Forms.Label();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(12, 175);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(456, 20);
            this.txtSourceFolder.TabIndex = 0;
            this.txtSourceFolder.Text = "C:\\ESTUDANTE\\data\\ThumbPreview";
            this.txtSourceFolder.TextChanged += new System.EventHandler(this.txtSourceFolder_TextChanged);
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.Location = new System.Drawing.Point(474, 173);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(167, 23);
            this.btnSourceFolder.TabIndex = 1;
            this.btnSourceFolder.Text = "Selecionar Pasta de Origem";
            this.btnSourceFolder.UseVisualStyleBackColor = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(12, 202);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(456, 20);
            this.txtDestinationFolder.TabIndex = 2;
            this.txtDestinationFolder.Text = "C:\\ESTUDANTE\\data\\Convertido";
            this.txtDestinationFolder.TextChanged += new System.EventHandler(this.txtDestinationFolder_TextChanged);
            // 
            // btnDestinationFolder
            // 
            this.btnDestinationFolder.Location = new System.Drawing.Point(474, 200);
            this.btnDestinationFolder.Name = "btnDestinationFolder";
            this.btnDestinationFolder.Size = new System.Drawing.Size(167, 23);
            this.btnDestinationFolder.TabIndex = 3;
            this.btnDestinationFolder.Text = "Selecionar Pasta de Destino";
            this.btnDestinationFolder.UseVisualStyleBackColor = true;
            this.btnDestinationFolder.Click += new System.EventHandler(this.btnDestinationFolder_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(648, 173);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(140, 50);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Converter Imagens";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // pbProgressBar
            // 
            this.pbProgressBar.Location = new System.Drawing.Point(12, 285);
            this.pbProgressBar.Name = "pbProgressBar";
            this.pbProgressBar.Size = new System.Drawing.Size(776, 23);
            this.pbProgressBar.TabIndex = 5;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Location = new System.Drawing.Point(12, 266);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(123, 13);
            this.lblProgressBar.TabIndex = 6;
            this.lblProgressBar.Text = "Progresso de Conversão";
            // 
            // bwConverter
            // 
            this.bwConverter.WorkerReportsProgress = true;
            this.bwConverter.WorkerSupportsCancellation = true;
            this.bwConverter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConverter_DoWork);
            this.bwConverter.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwConverter_ProgressChanged);
            this.bwConverter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwConverter_RunWorkerCompleted);
            // 
            // lblTotalSourceFiles
            // 
            this.lblTotalSourceFiles.AutoSize = true;
            this.lblTotalSourceFiles.Location = new System.Drawing.Point(15, 229);
            this.lblTotalSourceFiles.Name = "lblTotalSourceFiles";
            this.lblTotalSourceFiles.Size = new System.Drawing.Size(102, 13);
            this.lblTotalSourceFiles.TabIndex = 7;
            this.lblTotalSourceFiles.Text = "Total de Arquivos: 0";
            // 
            // lblTutorial
            // 
            this.lblTutorial.AutoSize = true;
            this.lblTutorial.ForeColor = System.Drawing.Color.Red;
            this.lblTutorial.Location = new System.Drawing.Point(15, 148);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(635, 13);
            this.lblTutorial.TabIndex = 9;
            this.lblTutorial.Text = "Dica:  Descompacte o arquivo enviado para você, depois escolha a pasta ./data/Thu" +
    "mbPreview como pasta de origem das imagens";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PSGWorksDecrypter.Properties.Resources.app_logo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.lblTutorial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotalSourceFiles);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.pbProgressBar);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnDestinationFolder);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.btnSourceFolder);
            this.Controls.Add(this.txtSourceFolder);
            this.Name = "MainForm";
            this.Text = "PSGWorks Decrypter v1.0.0 (por Sony)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdSourceFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnSourceFolder;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Button btnDestinationFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdDestinationFolder;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ProgressBar pbProgressBar;
        private System.Windows.Forms.Label lblProgressBar;
        private System.ComponentModel.BackgroundWorker bwConverter;
        private System.Windows.Forms.Label lblTotalSourceFiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTutorial;
    }
}

