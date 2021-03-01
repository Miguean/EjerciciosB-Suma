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

namespace E2
{
    public partial class E2 : Form
    {
        public E2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (tbx1.Text != "" && tbx2.Text != "" && tbx3.Text != "")
            {
                tbxResultado.Text = (Convert.ToInt32(tbx1.Text) + Convert.ToInt32(tbx2.Text) + Convert.ToInt32(tbx3.Text)).ToString();
                lblError.Hide();
                tbxResultado.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbx1.Clear();
            tbx2.Clear();
            tbx3.Clear();
            tbxResultado.Clear();
            tbx1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbx1_TextChanged(object sender, EventArgs e)
        {
            if (tbx1.Text != "")
            {
                int c = Convert.ToInt32(tbx1.Text);
                if (!(c >= 0 && c <= 10))
                {
                    lblError.Show();
                    tbx1.Clear();
                    tbx1.Focus();
                }
            }
        }

        private void tbx2_TextChanged(object sender, EventArgs e)
        {
            if (tbx2.Text != "")
            {
                int c = Convert.ToInt32(tbx2.Text);
                if (!(c >= 0 && c <= 10))
                {
                    lblError.Show();
                    tbx2.Clear();
                    tbx2.Focus();
                }
            }
        }

        private void tbx3_TextChanged(object sender, EventArgs e)
        {
            if (tbx3.Text != "")
            {
                int c = Convert.ToInt32(tbx3.Text);
                if (!(c >= 0 && c <= 10))
                {
                    lblError.Show();
                    tbx3.Clear();
                    tbx3.Focus();
                }
            }
        }
    }
}
