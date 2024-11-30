using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_PRACTICE
{
    public partial class frm_ListBox : Form
    {
        public frm_ListBox()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            listBox_01.Items.Add(txt_Type.Text);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            listBox_01.Items.RemoveAt(listBox_01.SelectedIndex);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co that su muon thoat? YES/NO", "Thong Bao", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
