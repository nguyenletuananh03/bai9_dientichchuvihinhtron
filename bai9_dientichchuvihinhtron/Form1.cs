using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai9_dientichchuvihinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double so = double.Parse(txtso.Text);
            double chuvi, dientich;
            if(rdbcv.Checked )
            {
                chuvi = Math.PI * (so * 2);
                txtKQ.Text = chuvi.ToString(); 
            }
            if (rdbdt.Checked)
            {
                dientich = Math.PI * (so * so);
                txtKQ.Text = dientich.ToString();
            }
        }
    }
}
