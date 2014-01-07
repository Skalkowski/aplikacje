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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabelki = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kasowanie_komorka = new System.Windows.Forms.Button();
            this.kasowanie_marka = new System.Windows.Forms.Button();
            this.kasowanie_osoba = new System.Windows.Forms.Button();
            this.komorka = new System.Windows.Forms.ComboBox();
            this.marka = new System.Windows.Forms.ComboBox();
            this.osoba = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imie = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.wybor = new System.Windows.Forms.ComboBox();
            this.imieUpdate = new System.Windows.Forms.TextBox();
            this.nazwiskoUpdate = new System.Windows.Forms.TextBox();
            this.wczytaj = new System.Windows.Forms.Button();
            this.aktualizuj = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 265);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tabelki);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Komórka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Osoba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabelki
            // 
            this.tabelki.Location = new System.Drawing.Point(227, 18);
            this.tabelki.Name = "tabelki";
            this.tabelki.Size = new System.Drawing.Size(315, 193);
            this.tabelki.TabIndex = 0;
            this.tabelki.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.kasowanie_komorka);
            this.tabPage2.Controls.Add(this.kasowanie_marka);
            this.tabPage2.Controls.Add(this.kasowanie_osoba);
            this.tabPage2.Controls.Add(this.komorka);
            this.tabPage2.Controls.Add(this.marka);
            this.tabPage2.Controls.Add(this.osoba);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // kasowanie_komorka
            // 
            this.kasowanie_komorka.Location = new System.Drawing.Point(473, 98);
            this.kasowanie_komorka.Name = "kasowanie_komorka";
            this.kasowanie_komorka.Size = new System.Drawing.Size(75, 23);
            this.kasowanie_komorka.TabIndex = 5;
            this.kasowanie_komorka.Text = "button5";
            this.kasowanie_komorka.UseVisualStyleBackColor = true;
            this.kasowanie_komorka.Click += new System.EventHandler(this.kasowanie_komorka_Click);
            // 
            // kasowanie_marka
            // 
            this.kasowanie_marka.Location = new System.Drawing.Point(473, 71);
            this.kasowanie_marka.Name = "kasowanie_marka";
            this.kasowanie_marka.Size = new System.Drawing.Size(75, 23);
            this.kasowanie_marka.TabIndex = 4;
            this.kasowanie_marka.Text = "button4";
            this.kasowanie_marka.UseVisualStyleBackColor = true;
            this.kasowanie_marka.Click += new System.EventHandler(this.kasowanie_marka_Click);
            // 
            // kasowanie_osoba
            // 
            this.kasowanie_osoba.Location = new System.Drawing.Point(473, 41);
            this.kasowanie_osoba.Name = "kasowanie_osoba";
            this.kasowanie_osoba.Size = new System.Drawing.Size(75, 23);
            this.kasowanie_osoba.TabIndex = 3;
            this.kasowanie_osoba.Text = "button3";
            this.kasowanie_osoba.UseVisualStyleBackColor = true;
            this.kasowanie_osoba.Click += new System.EventHandler(this.kasowanie_osoba_Click);
            // 
            // komorka
            // 
            this.komorka.FormattingEnabled = true;
            this.komorka.Location = new System.Drawing.Point(308, 98);
            this.komorka.Name = "komorka";
            this.komorka.Size = new System.Drawing.Size(121, 21);
            this.komorka.TabIndex = 2;
            // 
            // marka
            // 
            this.marka.FormattingEnabled = true;
            this.marka.Location = new System.Drawing.Point(308, 71);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(121, 21);
            this.marka.TabIndex = 1;
            // 
            // osoba
            // 
            this.osoba.FormattingEnabled = true;
            this.osoba.Location = new System.Drawing.Point(308, 44);
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
            this.tabPage3.Size = new System.Drawing.Size(862, 239);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(117, 63);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(100, 20);
            this.imie.TabIndex = 0;
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(334, 62);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(100, 20);
            this.nazwisko.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.aktualizuj);
            this.tabPage4.Controls.Add(this.wczytaj);
            this.tabPage4.Controls.Add(this.nazwiskoUpdate);
            this.tabPage4.Controls.Add(this.imieUpdate);
            this.tabPage4.Controls.Add(this.wybor);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(862, 239);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // wybor
            // 
            this.wybor.FormattingEnabled = true;
            this.wybor.Location = new System.Drawing.Point(131, 30);
            this.wybor.Name = "wybor";
            this.wybor.Size = new System.Drawing.Size(121, 21);
            this.wybor.TabIndex = 0;
            // 
            // imieUpdate
            // 
            this.imieUpdate.Location = new System.Drawing.Point(131, 57);
            this.imieUpdate.Name = "imieUpdate";
            this.imieUpdate.Size = new System.Drawing.Size(100, 20);
            this.imieUpdate.TabIndex = 1;
            // 
            // nazwiskoUpdate
            // 
            this.nazwiskoUpdate.Location = new System.Drawing.Point(131, 83);
            this.nazwiskoUpdate.Name = "nazwiskoUpdate";
            this.nazwiskoUpdate.Size = new System.Drawing.Size(100, 20);
            this.nazwiskoUpdate.TabIndex = 2;
            // 
            // wczytaj
            // 
            this.wczytaj.Location = new System.Drawing.Point(131, 109);
            this.wczytaj.Name = "wczytaj";
            this.wczytaj.Size = new System.Drawing.Size(75, 23);
            this.wczytaj.TabIndex = 3;
            this.wczytaj.Text = "button4";
            this.wczytaj.UseVisualStyleBackColor = true;
            this.wczytaj.Click += new System.EventHandler(this.wczytaj_Click);
            // 
            // aktualizuj
            // 
            this.aktualizuj.Location = new System.Drawing.Point(255, 109);
            this.aktualizuj.Name = "aktualizuj";
            this.aktualizuj.Size = new System.Drawing.Size(75, 23);
            this.aktualizuj.TabIndex = 4;
            this.aktualizuj.Text = "button5";
            this.aktualizuj.UseVisualStyleBackColor = true;
            this.aktualizuj.Click += new System.EventHandler(this.aktualizuj_Click);
            // 
            // polo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 262);
            this.Controls.Add(this.tabControl1);
            this.Name = "polo";
            this.Text = "polo";
            this.Load += new System.EventHandler(this.polo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.Button wczytaj;
        private System.Windows.Forms.TextBox nazwiskoUpdate;
        private System.Windows.Forms.TextBox imieUpdate;
        private System.Windows.Forms.ComboBox wybor;

    }
}