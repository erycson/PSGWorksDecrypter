using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace PSGWorksDecrypter
{
    public partial class MainForm : Form
    {

        private byte[] DecryptKey = Encoding.ASCII.GetBytes("7y1,^5aY.|g{46R<");
        private string SourceFolder;
        private string DestinationFolder;
        private string[] Images;

        public MainForm()
        {
            InitializeComponent();
        }

        void btnSourceFolder_Click(object sender, EventArgs e)
        {
            if (fbdSourceFolder.ShowDialog() != DialogResult.OK)
                return;

            SourceFolder = txtSourceFolder.Text = fbdSourceFolder.SelectedPath;
            GetFilesFromSourcePath();
        }

        void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            if (fbdDestinationFolder.ShowDialog() != DialogResult.OK)
                return;

            DestinationFolder = txtDestinationFolder.Text = fbdDestinationFolder.SelectedPath;
        }

        void btnConvert_Click(object sender, EventArgs e)
        {

            if (bwConverter.CancellationPending)
            {
                // Nada a fazer, só esperar
            }
            else if (bwConverter.IsBusy)
            {
                btnConvert.Text = "Cancelando...";
                btnConvert.Enabled = false;
                bwConverter.CancelAsync();
            }
            else if (IsValidFrom())
            {
                BlockComponents();
                bwConverter.RunWorkerAsync();
            }

        }

        void BlockComponents()
        {
            btnConvert.Text = "Cancelar";

            btnDestinationFolder.Enabled = false;
            txtDestinationFolder.Enabled = false;

            txtSourceFolder.Enabled = false;
            btnSourceFolder.Enabled = false;

            pbProgressBar.Value = 0;
        }

        void UnlockComponents()
        {
            btnConvert.Enabled = true;
            btnConvert.Text = "Converter Imagens";

            btnDestinationFolder.Enabled = true;
            txtDestinationFolder.Enabled = true;

            txtSourceFolder.Enabled = true;
            btnSourceFolder.Enabled = true;

            pbProgressBar.Value = 0;
        }

        bool IsValidFrom()
        {
            txtSourceFolder_TextChanged(null, null);
            txtDestinationFolder_TextChanged(null, null);

            if (!Directory.Exists(SourceFolder))
            {
                MessageBox.Show("A pasta de origem das imagens é inválida: " + SourceFolder);
                return false;
            }
            else if (!Directory.Exists(DestinationFolder))
            {
                MessageBox.Show("A pasta de destino das imagens é inválida: " + DestinationFolder);
                return false;
            }
            else if (SourceFolder == DestinationFolder)
            {
                MessageBox.Show("A pasta de origem e destino devem ser diferentes");
                return false;
            }

            return true;
        }

        void GetFilesFromSourcePath()
        {
            try
            {
                Images = Directory.GetFiles(SourceFolder);
                lblTotalSourceFiles.Text = "Total de Arquivos: " + Images.Length;
            }
            catch (Exception e)
            {
                lblTotalSourceFiles.Text = "Total de Arquivos: 0";
            }
        }

        void DecryptImage(string imagePath)
        {
            byte[] image;
            byte[] header = new byte[900];
            string destinationPath = new Uri(DestinationFolder + "/" + Path.GetFileName(imagePath)).LocalPath;

            using (FileStream sourceStream = File.Open(imagePath, FileMode.Open))
            {
                image = new byte[sourceStream.Length];
                sourceStream.Read(image, 0, (int)sourceStream.Length);
            }

            Array.Copy(image, header, 900);
            byte[] decrypted = RC4.Decrypt(DecryptKey, header);
            Array.Copy(decrypted, 0, image, 0, 900);

            using (FileStream sourceStream = File.Open(destinationPath, FileMode.Create))
            {
                sourceStream.Write(image, 0, image.Length);
            }
        }

        void bwConverter_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < Images.Length && !bwConverter.CancellationPending; i++)
            {
                DecryptImage(Images[i]);
                bwConverter.ReportProgress(i * 100 / Images.Length);
            }

            if (bwConverter.CancellationPending)
                e.Cancel = true;
        }

        void bwConverter_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbProgressBar.Value = e.ProgressPercentage;
        }

        void bwConverter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Erro durando a conversão das imagens");
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("Conversão cancelada");
            }
            else
            {
                MessageBox.Show("Conversão concluida com sucesso");
            }

            UnlockComponents();
        }

        void txtSourceFolder_TextChanged(object sender, EventArgs e)
        {
            SourceFolder = txtSourceFolder.Text;
            GetFilesFromSourcePath();
        }

        void txtDestinationFolder_TextChanged(object sender, EventArgs e)
        {
            DestinationFolder = txtDestinationFolder.Text;
        }
    }
}
