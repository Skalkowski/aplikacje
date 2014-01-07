using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Polaczenie
    {
        SqlConnection connectionSql = new SqlConnection("Data Source=eos.inf.ug.edu.pl; Initial Catalog=mskalkowski;Persist Security Info=True;User ID=mskalkowski;Password=194916");

        public ArrayList drukuj(String nazwa)
        {
            ArrayList select = new ArrayList();
            SqlDataReader tabela;

            connectionSql.Open();
            SqlCommand wybor = new SqlCommand(nazwa, connectionSql);

            tabela = wybor.ExecuteReader();

            while (tabela.Read())
            {
                String tabela_wartosci = "";

                for (int i = 0; i < tabela.FieldCount; i++)
                {
                    tabela_wartosci = tabela_wartosci + " " + tabela[i];
                }
                select.Add(tabela_wartosci + "\n");
            }

            if (tabela != null)
            {
                tabela.Close();
            }
            if (connectionSql != null)
            {
                connectionSql.Close();
            }
            return select;
        }

        public void dodanie(String dodana)
        {
            SqlCommand cmd = new SqlCommand(dodana, connectionSql);
            connectionSql.Open();
            cmd.ExecuteReader();
            connectionSql.Close();
        }
    
  
    }
}
