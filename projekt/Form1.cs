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
            Offlina offline = new Offlina();
            offline.ShowDialog();
            this.Close(); //zamkniecie form1
        }

        private void osobaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.osobaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.osoba' table. You can move, or remove it, as needed.
            this.osobaTableAdapter.Fill(this.dataSet2.osoba);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Michał Skałkowski\n194916", "Autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
