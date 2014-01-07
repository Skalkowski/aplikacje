using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class polo : Form
    {
        private int upNazwisko;
        private int upMarka;
        private int upKomorka;
        private Polaczenie pol = new Polaczenie();
        public polo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabelki.Clear();
            ArrayList wszystko = pol.drukuj("SELECT * FROM osoba;");
            
            for (int i = 0; i < wszystko.Count; i++)
            {
                tabelki.AppendText(wszystko[i] + "\n");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabelki.Clear();
            ArrayList wszystko = pol.drukuj("SELECT k.model,k.waga,k.cena,o.nazwisko, m.nazwa FROM komorka k Join osoba o ON k.id_osoba = o.id_osoba Join marka m ON k.id_marka= m.id_marka;");

            for (int i = 0; i < wszystko.Count; i++)
            {
                tabelki.AppendText(wszystko[i] + "\n");
            }

        }

        private void polo_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection sqlConn = new SqlConnection("Data Source=eos.inf.ug.edu.pl; Initial Catalog=mskalkowski;Persist Security Info=True;User ID=mskalkowski;Password=194916"))
            {
                sqlConn.Open();
               

                SqlCommand sqlCmd = new SqlCommand("SELECT nazwisko FROM osoba;", sqlConn);
                using (SqlDataReader saReader = sqlCmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string name = saReader.GetString(0);
                        osoba.Items.Add(name);
                        
                    }
                }
                
                SqlCommand sqlCmd1 = new SqlCommand("SELECT nazwa FROM marka;", sqlConn);
                using (SqlDataReader saReader1 = sqlCmd1.ExecuteReader())
                {
                    while (saReader1.Read())
                    {
                        string name = saReader1.GetString(0);
                        marka.Items.Add(name);
                    }
                }


                SqlCommand sqlCmd2 = new SqlCommand("SELECT model FROM komorka;", sqlConn);
                using (SqlDataReader saReader2 = sqlCmd2.ExecuteReader())
                {
                    while (saReader2.Read())
                    {
                        string name = saReader2.GetString(0);
                        komorka.Items.Add(name);
                    }
                }

                SqlCommand sqlCmd3 = new SqlCommand("SELECT nazwisko FROM osoba;", sqlConn);
                using (SqlDataReader saReader3 = sqlCmd3.ExecuteReader())
                {
                    while (saReader3.Read())
                    {
                        string name = saReader3.GetString(0);
                        wybor.Items.Add(name);
                    }
                }

                SqlCommand sqlCmd4 = new SqlCommand("SELECT nazwa FROM marka;", sqlConn);
                using (SqlDataReader saReader4 = sqlCmd4.ExecuteReader())
                {
                    while (saReader4.Read())
                    {
                        string name = saReader4.GetString(0);
                        wybor2.Items.Add(name);
                    }
                }

                SqlCommand sqlCmd5 = new SqlCommand("SELECT model FROM komorka;", sqlConn);
                using (SqlDataReader saReader5 = sqlCmd5.ExecuteReader())
                {
                    while (saReader5.Read())
                    {
                        string name = saReader5.GetString(0);
                        wybor3.Items.Add(name);
                    }
                }
                
                sqlConn.Close();
            }
        }

        private void kasowanie_osoba_Click(object sender, EventArgs e)
        {
            String osobaKasowanie = (String)osoba.SelectedItem;

            using (SqlConnection sqlConn = new SqlConnection("Data Source=eos.inf.ug.edu.pl; Initial Catalog=mskalkowski;Persist Security Info=True;User ID=mskalkowski;Password=194916"))
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("Delete from osoba where nazwisko = @osobaKasowanie;", sqlConn);
                SqlParameter osob = new SqlParameter("@osobaKasowanie", osobaKasowanie);
                sqlCmd.Parameters.Add(osob);
                try
                {
                    sqlCmd.ExecuteReader();
                    MessageBox.Show("Usunięto", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Nie można usunąć, wybierz wpierw osobę,\nlub usuń wpierw wszystkie modele komórki tej osoby!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConn.Close();
            }

            osoba.Items.Clear();
            marka.Items.Clear();
            komorka.Items.Clear();
            polo_Load(sender, e);
            
        }

        private void kasowanie_marka_Click(object sender, EventArgs e)
        {
            String markaKasowanie = (String)marka.SelectedItem;

            using (SqlConnection sqlConn = new SqlConnection("Data Source=eos.inf.ug.edu.pl; Initial Catalog=mskalkowski;Persist Security Info=True;User ID=mskalkowski;Password=194916"))
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("Delete from marka where nazwa = @markaKasowanie;", sqlConn);
                SqlParameter mark = new SqlParameter("@markaKasowanie", markaKasowanie);
                sqlCmd.Parameters.Add(mark);
                try
                {
                    sqlCmd.ExecuteReader();
                    MessageBox.Show("Usunięto", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Nie można usunąć, wybierz wpierw markę,\nlub usuń wszystkie modele komórki tej marki!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConn.Close();
            }

            osoba.Items.Clear();
            marka.Items.Clear();
            komorka.Items.Clear();
            polo_Load(sender, e);
        }

        private void kasowanie_komorka_Click(object sender, EventArgs e)
        {
            String komorkaKasowanie = (String)komorka.SelectedItem;

            using (SqlConnection sqlConn = new SqlConnection("Data Source=eos.inf.ug.edu.pl; Initial Catalog=mskalkowski;Persist Security Info=True;User ID=mskalkowski;Password=194916"))
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("Delete from komorka where model = @komorkaKasowanie;", sqlConn);
                SqlParameter kom = new SqlParameter("@komorkaKasowanie", komorkaKasowanie);
                sqlCmd.Parameters.Add(kom);
                try
                {
                    sqlCmd.ExecuteReader();
                    MessageBox.Show("Deleted", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConn.Close();
            }

            osoba.Items.Clear();
            marka.Items.Clear();
            komorka.Items.Clear();
            polo_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String imiecos = imie.Text;
            String nazwiskocos = nazwisko.Text;
            try
            {

                pol.dodanie("INSERT INTO osoba (imie, nazwisko) VALUES ('" + imiecos + "', '" + nazwiskocos + "');");
                MessageBox.Show("ok");
            }
            catch
            {
                MessageBox.Show("dupa");
            }
        }

        private void wczytaj_Click(object sender, EventArgs e)
        {
            String poWyborze = (String)wybor.SelectedItem;
            using (SqlConnection sqlConn = new SqlConnection("Data Source=eos.inf.ug.edu.pl; Initial Catalog=mskalkowski;Persist Security Info=True;User ID=mskalkowski;Password=194916"))
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("SELECT id_osoba, imie, nazwisko FROM osoba where nazwisko = @nazwisko",sqlConn);
                SqlParameter nazwisko = new SqlParameter("@nazwisko", poWyborze);
                sqlCmd.Parameters.Add(nazwisko);
                using (SqlDataReader saReader = sqlCmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        upNazwisko = saReader.GetInt32(0);
                        imieUpdate.Text = saReader.GetString(1);
                        nazwiskoUpdate.Text = saReader.GetString(2);
                      
                    }
                }

                sqlConn.Close();
            }
        }

        private void aktualizuj_Click(object sender, EventArgs e)
        {
            String imie = imieUpdate.Text;
            String nazwisko = nazwiskoUpdate.Text;

            String komenda = "UPDATE osoba SET imie='" + imie + "', nazwisko='" + nazwisko + "' WHERE id_osoba = '" + upNazwisko + "'";
            pol.dodanie(komenda);
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            String poWyborze = (String)wybor2.SelectedItem;
            using (SqlConnection sqlConn = new SqlConnection("Data Source=eos.inf.ug.edu.pl; Initial Catalog=mskalkowski;Persist Security Info=True;User ID=mskalkowski;Password=194916"))
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("SELECT id_marka, nazwa, kraj FROM marka where nazwa = @nazwa", sqlConn);
                SqlParameter nazwa = new SqlParameter("@nazwa", poWyborze);
                sqlCmd.Parameters.Add(nazwa);
                using (SqlDataReader saReader = sqlCmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        upMarka = saReader.GetInt32(0);
                        nazwaUpdate.Text = saReader.GetString(1);
                        krajUpdate.Text = saReader.GetString(2);

                    }
                }

                sqlConn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String nazwa = nazwaUpdate.Text;
            String kraj = krajUpdate.Text;

            String komenda = "UPDATE marka SET nazwa='" + nazwa + "', kraj='" + kraj + "' WHERE id_marka = '" + upMarka + "'";
            pol.dodanie(komenda);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            String poWyborze = (String)wybor3.SelectedItem;
            using (SqlConnection sqlConn = new SqlConnection("Data Source=eos.inf.ug.edu.pl; Initial Catalog=mskalkowski;Persist Security Info=True;User ID=mskalkowski;Password=194916"))
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("SELECT id_komorka, model, waga, cena FROM komorka where model = @model", sqlConn);
                SqlParameter model = new SqlParameter("@model", poWyborze);
                sqlCmd.Parameters.Add(model);
                using (SqlDataReader saReader = sqlCmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        upKomorka = saReader.GetInt32(0);
                        modelUpdate.Text = saReader.GetString(1);
                        wagaUpdate.Text = saReader.GetInt32(2);

                    }
                }

                sqlConn.Close();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            String model = modelUpdate.Text;
            String waga = wagaUpdate.Text;
            String cena = cenaUpdate.Text;

            String komenda = "UPDATE komorka SET model='" + model + "', waga='" + waga + "',  cena='" + cena + "' WHERE id_komorka = '" + upKomorka + "'";
            pol.dodanie(komenda);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //schowanie form1
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close(); //zamkniecie form1
        }

        private void tabelki_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabelki.Clear();
            ArrayList wszystko = pol.drukuj("SELECT * FROM marka;");

            for (int i = 0; i < wszystko.Count; i++)
            {
                tabelki.AppendText(wszystko[i] + "\n");
            }
        }

        private void wybor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void imieUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

       
      

     

       
    }
}
