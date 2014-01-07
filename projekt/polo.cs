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
    }
}
