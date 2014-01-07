namespace projekt
{
    partial class polo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabelki = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kasowanie_komorka = new System.Windows.Forms.Button();
            this.kasowanie_marka = new System.Windows.Forms.Button();
            this.kasowanie_osoba = new System.Windows.Forms.Button();
            this.komorka = new System.Windows.Forms.ComboBox();
            this.marka = new System.Windows.Forms.ComboBox();
            this.osoba = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.imie = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.aktualizuj = new System.Windows.Forms.Button();
            this.wczytajOsoba = new System.Windows.Forms.Button();
            this.nazwiskoUpdate = new System.Windows.Forms.TextBox();
            this.imieUpdate = new System.Windows.Forms.TextBox();
            this.wybor = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wybor2 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.nazwaUpdate = new System.Windows.Forms.TextBox();
            this.krajUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wybor3 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.modelUpdate = new System.Windows.Forms.TextBox();
            this.wagaUpdate = new System.Windows.Forms.TextBox();
            this.cenaUpdate = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(669, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tabelki);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pokaż wszystkie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(127, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Marka";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Komórka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Osoba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabelki
            // 
            this.tabelki.Location = new System.Drawing.Point(6, 39);
            this.tabelki.Name = "tabelki";
            this.tabelki.Size = new System.Drawing.Size(379, 190);
            this.tabelki.TabIndex = 0;
            this.tabelki.Text = "";
            this.tabelki.TextChanged += new System.EventHandler(this.tabelki_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.kasowanie_komorka);
            this.tabPage2.Controls.Add(this.kasowanie_marka);
            this.tabPage2.Controls.Add(this.kasowanie_osoba);
            this.tabPage2.Controls.Add(this.komorka);
            this.tabPage2.Controls.Add(this.marka);
            this.tabPage2.Controls.Add(this.osoba);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(469, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuń";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(342, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(168, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Osoba";
            // 
            // kasowanie_komorka
            // 
            this.kasowanie_komorka.Location = new System.Drawing.Point(345, 140);
            this.kasowanie_komorka.Name = "kasowanie_komorka";
            this.kasowanie_komorka.Size = new System.Drawing.Size(75, 23);
            this.kasowanie_komorka.TabIndex = 5;
            this.kasowanie_komorka.Text = "Usuń";
            this.kasowanie_komorka.UseVisualStyleBackColor = true;
            this.kasowanie_komorka.Click += new System.EventHandler(this.kasowanie_komorka_Click);
            // 
            // kasowanie_marka
            // 
            this.kasowanie_marka.Location = new System.Drawing.Point(171, 140);
            this.kasowanie_marka.Name = "kasowanie_marka";
            this.kasowanie_marka.Size = new System.Drawing.Size(75, 23);
            this.kasowanie_marka.TabIndex = 4;
            this.kasowanie_marka.Text = "Usuń";
            this.kasowanie_marka.UseVisualStyleBackColor = true;
            this.kasowanie_marka.Click += new System.EventHandler(this.kasowanie_marka_Click);
            // 
            // kasowanie_osoba
            // 
            this.kasowanie_osoba.Location = new System.Drawing.Point(9, 140);
            this.kasowanie_osoba.Name = "kasowanie_osoba";
            this.kasowanie_osoba.Size = new System.Drawing.Size(75, 23);
            this.kasowanie_osoba.TabIndex = 3;
            this.kasowanie_osoba.Text = "Usuń";
            this.kasowanie_osoba.UseVisualStyleBackColor = true;
            this.kasowanie_osoba.Click += new System.EventHandler(this.kasowanie_osoba_Click);
            // 
            // komorka
            // 
            this.komorka.FormattingEnabled = true;
            this.komorka.Location = new System.Drawing.Point(345, 57);
            this.komorka.Name = "komorka";
            this.komorka.Size = new System.Drawing.Size(121, 21);
            this.komorka.TabIndex = 2;
            // 
            // marka
            // 
            this.marka.FormattingEnabled = true;
            this.marka.Location = new System.Drawing.Point(171, 57);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(121, 21);
            this.marka.TabIndex = 1;
            // 
            // osoba
            // 
            this.osoba.FormattingEnabled = true;
            this.osoba.Location = new System.Drawing.Point(9, 57);
            this.osoba.Name = "osoba";
            this.osoba.Size = new System.Drawing.Size(121, 21);
            this.osoba.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.nazwisko);
            this.tabPage3.Controls.Add(this.imie);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(469, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dodaj";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(14, 56);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(100, 20);
            this.nazwisko.TabIndex = 1;
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(14, 30);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(100, 20);
            this.imie.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.cenaUpdate);
            this.tabPage4.Controls.Add(this.wagaUpdate);
            this.tabPage4.Controls.Add(this.modelUpdate);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.wybor3);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.krajUpdate);
            this.tabPage4.Controls.Add(this.nazwaUpdate);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.wybor2);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.aktualizuj);
            this.tabPage4.Controls.Add(this.wczytajOsoba);
            this.tabPage4.Controls.Add(this.nazwiskoUpdate);
            this.tabPage4.Controls.Add(this.imieUpdate);
            this.tabPage4.Controls.Add(this.wybor);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(661, 321);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Aktualizuj";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // aktualizuj
            // 
            this.aktualizuj.Location = new System.Drawing.Point(22, 198);
            this.aktualizuj.Name = "aktualizuj";
            this.aktualizuj.Size = new System.Drawing.Size(75, 23);
            this.aktualizuj.TabIndex = 4;
            this.aktualizuj.Text = "Aktualizuj";
            this.aktualizuj.UseVisualStyleBackColor = true;
            this.aktualizuj.Click += new System.EventHandler(this.aktualizuj_Click);
            // 
            // wczytajOsoba
            // 
            this.wczytajOsoba.Location = new System.Drawing.Point(22, 57);
            this.wczytajOsoba.Name = "wczytajOsoba";
            this.wczytajOsoba.Size = new System.Drawing.Size(75, 23);
            this.wczytajOsoba.TabIndex = 3;
            this.wczytajOsoba.Text = "Wczytuj";
            this.wczytajOsoba.UseVisualStyleBackColor = true;
            this.wczytajOsoba.Click += new System.EventHandler(this.wczytaj_Click);
            // 
            // nazwiskoUpdate
            // 
            this.nazwiskoUpdate.Location = new System.Drawing.Point(22, 172);
            this.nazwiskoUpdate.Name = "nazwiskoUpdate";
            this.nazwiskoUpdate.Size = new System.Drawing.Size(100, 20);
            this.nazwiskoUpdate.TabIndex = 2;
            // 
            // imieUpdate
            // 
            this.imieUpdate.Location = new System.Drawing.Point(22, 146);
            this.imieUpdate.Name = "imieUpdate";
            this.imieUpdate.Size = new System.Drawing.Size(100, 20);
            this.imieUpdate.TabIndex = 1;
            this.imieUpdate.TextChanged += new System.EventHandler(this.imieUpdate_TextChanged);
            // 
            // wybor
            // 
            this.wybor.ForeColor = System.Drawing.Color.Black;
            this.wybor.FormattingEnabled = true;
            this.wybor.Location = new System.Drawing.Point(22, 30);
            this.wybor.Name = "wybor";
            this.wybor.Size = new System.Drawing.Size(121, 21);
            this.wybor.TabIndex = 0;
            this.wybor.SelectedIndexChanged += new System.EventHandler(this.wybor_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(606, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(190, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(19, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Osoba";
            // 
            // wybor2
            // 
            this.wybor2.FormattingEnabled = true;
            this.wybor2.Location = new System.Drawing.Point(193, 30);
            this.wybor2.Name = "wybor2";
            this.wybor2.Size = new System.Drawing.Size(121, 21);
            this.wybor2.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(193, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Wczytuj";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(193, 198);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "Aktualizuj";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // nazwaUpdate
            // 
            this.nazwaUpdate.Location = new System.Drawing.Point(193, 146);
            this.nazwaUpdate.Name = "nazwaUpdate";
            this.nazwaUpdate.Size = new System.Drawing.Size(100, 20);
            this.nazwaUpdate.TabIndex = 13;
            this.nazwaUpdate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // krajUpdate
            // 
            this.krajUpdate.Location = new System.Drawing.Point(193, 172);
            this.krajUpdate.Name = "krajUpdate";
            this.krajUpdate.Size = new System.Drawing.Size(100, 20);
            this.krajUpdate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(384, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Model";
            // 
            // wybor3
            // 
            this.wybor3.FormattingEnabled = true;
            this.wybor3.Location = new System.Drawing.Point(387, 30);
            this.wybor3.Name = "wybor3";
            this.wybor3.Size = new System.Drawing.Size(121, 21);
            this.wybor3.TabIndex = 16;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(387, 57);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Wczytuj";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // modelUpdate
            // 
            this.modelUpdate.Location = new System.Drawing.Point(387, 146);
            this.modelUpdate.Name = "modelUpdate";
            this.modelUpdate.Size = new System.Drawing.Size(100, 20);
            this.modelUpdate.TabIndex = 18;
            // 
            // wagaUpdate
            // 
            this.wagaUpdate.Location = new System.Drawing.Point(387, 172);
            this.wagaUpdate.Name = "wagaUpdate";
            this.wagaUpdate.Size = new System.Drawing.Size(100, 20);
            this.wagaUpdate.TabIndex = 19;
            // 
            // cenaUpdate
            // 
            this.cenaUpdate.Location = new System.Drawing.Point(387, 201);
            this.cenaUpdate.Name = "cenaUpdate";
            this.cenaUpdate.Size = new System.Drawing.Size(100, 20);
            this.cenaUpdate.TabIndex = 20;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(387, 227);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "Aktualizuj";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // polo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 419);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.Name = "polo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online";
            this.Load += new System.EventHandler(this.polo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox tabelki;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox komorka;
        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.ComboBox osoba;
        private System.Windows.Forms.Button kasowanie_komorka;
        private System.Windows.Forms.Button kasowanie_marka;
        private System.Windows.Forms.Button kasowanie_osoba;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button aktualizuj;
        private System.Windows.Forms.Button wczytajOsoba;
        private System.Windows.Forms.TextBox nazwiskoUpdate;
        private System.Windows.Forms.TextBox imieUpdate;
        private System.Windows.Forms.ComboBox wybor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox wybor2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox krajUpdate;
        private System.Windows.Forms.TextBox nazwaUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox cenaUpdate;
        private System.Windows.Forms.TextBox wagaUpdate;
        private System.Windows.Forms.TextBox modelUpdate;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox wybor3;

    }
}