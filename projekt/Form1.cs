using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void polacz_Click(object sender, EventArgs e)
        {
            this.Hide(); //schowanie form1
            polo polo = new polo();
            polo.ShowDialog();
            this.Close(); //zamkniecie form1
        }

        private void bez_Click(object sender, EventArgs e)
        {
            this.Hide(); //schowanie form1
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close(); //zamkniecie form1
        }
    }
}
