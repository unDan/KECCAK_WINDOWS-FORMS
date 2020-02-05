using System;
using System.Windows.Forms;

namespace KeccakHash
{
    public partial class KeccakHash : Form
    {
        private UInt16 hash_length = 128;

        public KeccakHash()
        {
            InitializeComponent();

            HashTextField.TextChanged += HashTextField_TextChanged;
            HashLengthList.SetSelected(0, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void HashTextLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void HashTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterTextField_TextChanged(object sender, EventArgs e)
        {
            if(AutoUpdateCheckBox.Checked)
                HashTextField.Text = Keccak.createHashOf(EnterTextField.Text, hash_length);
        }

        private void EnterTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            HashTextField.Text =  Keccak.createHashOf(EnterTextField.Text, hash_length);
        }

        private void AutoUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void HashLengthList_SelectedIndexChanged(object sender, EventArgs e)
        {
           hash_length = Convert.ToUInt16(HashLengthList.SelectedItem);
        }
    }
}
