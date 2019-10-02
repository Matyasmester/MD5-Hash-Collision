using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MD5_Hash_Collision
{

    public partial class MainForm : Form
    {

        Main main = new Main();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void OriginalFileInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void EvilFileInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            animateProgressBar();
            resultBox.ForeColor = Color.White;
            if (string.Equals(main.goodEncrypted, main.evilEncrypted))
            {
                resultBox.Text = "Attack successful! They do have an indentical hash.";
                resultBox.BackColor = Color.Green;
            }
            else
            {
                resultBox.Text = "Attack failed! They do not have an identical hash.";
                resultBox.BackColor = Color.Red;
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        void animateProgressBar()
        {
            while (progressBar.Value < 100)
            {
                Thread.Sleep(10);
                progressBar.Value += 1;
            }
        }

        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BrowseGoodFile_Click(object sender, EventArgs e)
        {
            originalFileInput.Enabled = false;            
            main.goodEncrypted = main.Encrypt(getFilePath());
            originalFileInput.Text = fileDialog.FileName;
        }

        private void BrowseEvilFile_Click(object sender, EventArgs e)
        {
            evilFileInput.Enabled = false;
            main.evilEncrypted = main.Encrypt(getFilePath());
            evilFileInput.Text = fileDialog.FileName;
        }

        string getFilePath()
        {
            fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            return fileDialog.FileName;
        }
    }
}
