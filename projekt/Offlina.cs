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
    public partial class Offlina : Form
    {
        public Offlina()
        {
            InitializeComponent();
        }

        private void markaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.markaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void Offlina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.komorka' table. You can move, or remove it, as needed.
            this.komorkaTableAdapter.Fill(this.dataSet2.komorka);
            // TODO: This line of code loads data into the 'dataSet2.osoba' table. You can move, or remove it, as needed.
            this.osobaTableAdapter.Fill(this.dataSet2.osoba);
            // TODO: This line of code loads data into the 'dataSet2.marka' table. You can move, or remove it, as needed.
            this.markaTableAdapter.Fill(this.dataSet2.marka);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //schowanie form1
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close(); //zamkniecie form1
        }
    }
}
