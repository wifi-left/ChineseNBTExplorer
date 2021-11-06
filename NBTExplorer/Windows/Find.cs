using System;
using System.Windows.Forms;

namespace NBTExplorer.Windows
{
    public partial class Find : Form
    {
        public Find ()
        {
            InitializeComponent();
        }

        public bool MatchName
        {
            get { return _cbName.Checked; }
        }

        public bool MatchValue
        {
            get { return _cbValue.Checked; }
        }

        public string NameToken
        {
            get { return _textName.Text; }
        }

        public string ValueToken
        {
            get { return _textValue.Text; }
        }

        private void _buttonFind_Click (object sender, EventArgs e)
        {
            MessageBox.Show("注意：此过程将会消耗一些时间，可能会出现卡顿。若出现此问题，请重启此程序。", "Warning:");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void _buttonCancel_Click (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void _textName_TextChanged (object sender, EventArgs e)
        {
            _cbName.Checked = true;
        }

        private void _textValue_TextChanged (object sender, EventArgs e)
        {
            _cbValue.Checked = true;
        }
    }
}
