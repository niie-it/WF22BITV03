namespace MyWordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveDocument(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "Word Pad|*.rtf|Text|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(dlg.FileName).ToLower() == "*.rtf")
                {
                    richTextBox1.SaveFile(dlg.FileName);
                }
                else
                {
                    File.WriteAllText(dlg.FileName, richTextBox1.Text);
                }
            }
        }

        private void OpenDocument(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Word Pad|*.rtf|Text|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(dlg.FileName).ToLower() == "*.rtf")
                {
                    richTextBox1.LoadFile(dlg.FileName);
                }
                else
                {
                    richTextBox1.Text = File.ReadAllText(dlg.FileName);
                }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new FontDialog();
            dlg.ShowColor = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = dlg.Font;
                richTextBox1.SelectionColor = dlg.Color;
            }
        }

        private void insertImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Image file|*.jpg;*.gif;*.png;*.bmp;*.jpeg";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Clipboard.SetImage(Image.FromFile(dlg.FileName));
                richTextBox1.Paste();
            }
        }
    }
}
