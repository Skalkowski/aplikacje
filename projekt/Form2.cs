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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void osobaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.osobaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.osoba' table. You can move, or remove it, as needed.
            this.osobaTableAdapter.Fill(this.dataSet1.osoba);

        }
    }
}
