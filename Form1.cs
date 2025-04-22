using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._38
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
        }

        private void btmAdd_Click(object sender, EventArgs e)
        {
            float n1, n2, sum = 0;
            if (!float.TryParse(txtNum1.Text, out n1) || !float.TryParse(txtNum2.Text,out n2))
            {
                lstRis.Items.Add($"{"errore!"}");
            }
            else
            {
                sum = n1 + n2;
                lstRis.Items.Add( sum.ToString());
            }
            clear_Click(sender, e);
        }

        private void btmSottra_Click(object sender, EventArgs e)
        {
            float n1, n2, diff = 0 ;
            if (!float.TryParse(txtNum1.Text, out n1) || !float.TryParse(txtNum2.Text, out n2))
            {
                lstRis.Items.Add($"{"errore!"}");
            }
            else
            {
                diff = n1 - n2;
                lstRis.Items.Add(diff.ToString());
            }
            clear_Click(sender, e);
        }

        private void btmMolti_Click(object sender, EventArgs e)
        {
            float n1, n2, molti = 0;
            if (!float.TryParse(txtNum1.Text, out n1) || !float.TryParse(txtNum2.Text, out n2))
            {
                lstRis.Items.Add($"{"errore!"}");
            }
            else
            {
                molti = n1 * n2;
                lstRis.Items.Add(molti.ToString());
            }
            clear_Click(sender, e);
        }

        private void btmDiv_Click(object sender, EventArgs e)
        {
            float n1, n2, div = 0;
            if (!float.TryParse(txtNum1.Text, out n1) || !float.TryParse(txtNum2.Text, out n2))
            {
                lstRis.Items.Add($"{"errore!"}");
            }
            else
            {
                div = n1 / n2;
                lstRis.Items.Add(div.ToString());
            }
            clear_Click(sender, e);
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
