using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Week_3_VS
{
    public partial class FormPengaturanWarna : Form
    {
        public FormPengaturanWarna()
        {
            InitializeComponent();
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            if (TBoxInput.Text.ToUpper().IndexOf("ISI:") == 0)
            {
                LblOutput.Text = TBoxInput.Text.Remove(0,4);
            }
            else if (TBoxInput.Text.ToUpper().IndexOf("WARNA:") == 0)
            {
                if(TBoxInput.Text.ToUpper().IndexOf("DEFAULT") == 6)
                {
                    LblOutput.ForeColor = Color.Black;
                }
                if (TBoxInput.Text.ToUpper().IndexOf("MERAH") == 6)
                {
                    LblOutput.ForeColor = Color.Red;
                }
                if (TBoxInput.Text.ToUpper().IndexOf("HIJAU") == 6)
                {
                    LblOutput.ForeColor = Color.Green;
                }
                if (TBoxInput.Text.ToUpper().IndexOf("BIRU") == 6)
                {
                    LblOutput.ForeColor = Color.Blue;
                }
            }
            else if (TBoxInput.Text.ToUpper().IndexOf("HIDE") == 0)
            {
                LblOutput.Visible = false;
            }
            else if (TBoxInput.Text.ToUpper().IndexOf("SHOWN") == 0)
            {
                LblOutput.Visible = true;
            }

            else if (TBoxInput.Text.ToUpper().IndexOf("BESARKAN") == 0)
            {
                LblOutput.Font = new Font(LblOutput.Font.FontFamily, LblOutput.Font.Size + 1F, LblOutput.Font.Style);
            }
            else if (TBoxInput.Text.ToUpper().IndexOf("KECILKAN") == 0)
            {
                LblOutput.Font = new Font(LblOutput.Font.FontFamily, LblOutput.Font.Size - 1F, LblOutput.Font.Style);
            }
            else if (TBoxInput.Text.ToUpper().IndexOf("RESTART") == 0)
            {
                LblOutput.Font = new Font(LblOutput.Font.FontFamily, 9F, LblOutput.Font.Style);
            }

            else
            {
                MessageBox.Show("Syntax Tidak Terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
