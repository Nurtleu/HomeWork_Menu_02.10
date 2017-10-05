using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHW10
{
    public partial class TextEditor : Form
    {
        string file;
        public TextEditor()
        {
            InitializeComponent();
        }

        private void ExitToolStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveAsToolStrip_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.ShowDialog();
        }

        private void ExistingProjectToolStrip_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
        }

        private void OpenProjectToolStrip_Click(object sender, EventArgs e)
        {
            OpenFileDialog project = new OpenFileDialog();
            project.ShowDialog();
        }

        private void CutOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fileInfoTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem copyFile = new ToolStripMenuItem();
            copyFile.Click += CopyToolStripMenuItem_Click;
            file = fileInfoTextBox.SelectedText;
        }

        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem pasteFile = new ToolStripMenuItem();
            pasteFile.Click += InsertToolStripMenuItem_Click;
            fileInfoTextBox.Paste(file);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fileInfoTextBox.Clear();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fileInfoTextBox.SelectAll();
        }
    }
}
