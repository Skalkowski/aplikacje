namespace projekt
{
    partial class Offlina
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Offlina));
            this.dataSet2 = new projekt.DataSet2();
            this.markaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markaTableAdapter = new projekt.DataSet2TableAdapters.markaTableAdapter();
            this.tableAdapterManager = new projekt.DataSet2TableAdapters.TableAdapterManager();
            this.markaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.markaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.markaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Osoba = new System.Windows.Forms.TabPage();
            this.Marka = new System.Windows.Forms.TabPage();
            this.osobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osobaTableAdapter = new projekt.DataSet2TableAdapters.osobaTableAdapter();
            this.osobaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komorki = new System.Windows.Forms.TabPage();
            this.komorkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komorkaTableAdapter = new projekt.DataSet2TableAdapters.komorkaTableAdapter();
            this.komorkaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingNavigator)).BeginInit();
            this.markaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markaDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Osoba.SuspendLayout();
            this.Marka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaDataGridView)).BeginInit();
            this.komorki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.komorkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komorkaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markaBindingSource
            // 
            this.markaBindingSource.DataMember = "marka";
            this.markaBindingSource.DataSource = this.dataSet2;
            // 
            // markaTableAdapter
            // 
            this.markaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.komorkaTableAdapter = this.komorkaTableAdapter;
            this.tableAdapterManager.markaTableAdapter = this.markaTableAdapter;
            this.tableAdapterManager.osobaTableAdapter = this.osobaTableAdapter;
            this.tableAdapterManager.UpdateOrder = projekt.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // markaBindingNavigator
            // 
            this.markaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.markaBindingNavigator.BindingSource = this.markaBindingSource;
            this.markaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.markaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.markaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.markaBindingNavigatorSaveItem});
            this.markaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.markaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.markaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.markaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.markaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.markaBindingNavigator.Name = "markaBindingNavigator";
            this.markaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.markaBindingNavigator.Size = new System.Drawing.Size(663, 25);
            this.markaBindingNavigator.TabIndex = 0;
            this.markaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // markaBindingNavigatorSaveItem
            // 
            this.markaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.markaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("markaBindingNavigatorSaveItem.Image")));
            this.markaBindingNavigatorSaveItem.Name = "markaBindingNavigatorSaveItem";
            this.markaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.markaBindingNavigatorSaveItem.Text = "Save Data";
            this.markaBindingNavigatorSaveItem.Click += new System.EventHandler(this.markaBindingNavigatorSaveItem_Click);
            // 
            // markaDataGridView
            // 
            this.markaDataGridView.AutoGenerateColumns = false;
            this.markaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.markaDataGridView.DataSource = this.markaBindingSource;
            this.markaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.markaDataGridView.Name = "markaDataGridView";
            this.markaDataGridView.Size = new System.Drawing.Size(655, 267);
            this.markaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_marka";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_marka";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nazwa";
            this.dataGridViewTextBoxColumn2.HeaderText = "nazwa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kraj";
            this.dataGridViewTextBoxColumn3.HeaderText = "kraj";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Osoba);
            this.tabControl1.Controls.Add(this.Marka);
            this.tabControl1.Controls.Add(this.komorki);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 294);
            this.tabControl1.TabIndex = 2;
            // 
            // Osoba
            // 
            this.Osoba.Controls.Add(this.osobaDataGridView);
            this.Osoba.Location = new System.Drawing.Point(4, 22);
            this.Osoba.Name = "Osoba";
            this.Osoba.Padding = new System.Windows.Forms.Padding(3);
            this.Osoba.Size = new System.Drawing.Size(651, 268);
            this.Osoba.TabIndex = 0;
            this.Osoba.Text = "Osoba";
            this.Osoba.UseVisualStyleBackColor = true;
            // 
            // Marka
            // 
            this.Marka.Controls.Add(this.markaDataGridView);
            this.Marka.Location = new System.Drawing.Point(4, 22);
            this.Marka.Name = "Marka";
            this.Marka.Padding = new System.Windows.Forms.Padding(3);
            this.Marka.Size = new System.Drawing.Size(651, 268);
            this.Marka.TabIndex = 1;
            this.Marka.Text = "Marka";
            this.Marka.UseVisualStyleBackColor = true;
            // 
            // osobaBindingSource
            // 
            this.osobaBindingSource.DataMember = "osoba";
            this.osobaBindingSource.DataSource = this.dataSet2;
            // 
            // osobaTableAdapter
            // 
            this.osobaTableAdapter.ClearBeforeFill = true;
            // 
            // osobaDataGridView
            // 
            this.osobaDataGridView.AutoGenerateColumns = false;
            this.osobaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.osobaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.osobaDataGridView.DataSource = this.osobaBindingSource;
            this.osobaDataGridView.Location = new System.Drawing.Point(0, 3);
            this.osobaDataGridView.Name = "osobaDataGridView";
            this.osobaDataGridView.Size = new System.Drawing.Size(651, 265);
            this.osobaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_osoba";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_osoba";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "imie";
            this.dataGridViewTextBoxColumn5.HeaderText = "imie";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nazwisko";
            this.dataGridViewTextBoxColumn6.HeaderText = "nazwisko";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // komorki
            // 
            this.komorki.AutoScroll = true;
            this.komorki.Controls.Add(this.komorkaDataGridView);
            this.komorki.Location = new System.Drawing.Point(4, 22);
            this.komorki.Name = "komorki";
            this.komorki.Size = new System.Drawing.Size(651, 268);
            this.komorki.TabIndex = 2;
            this.komorki.Text = "Komorki";
            this.komorki.UseVisualStyleBackColor = true;
            // 
            // komorkaBindingSource
            // 
            this.komorkaBindingSource.DataMember = "komorka";
            this.komorkaBindingSource.DataSource = this.dataSet2;
            // 
            // komorkaTableAdapter
            // 
            this.komorkaTableAdapter.ClearBeforeFill = true;
            // 
            // komorkaDataGridView
            // 
            this.komorkaDataGridView.AutoGenerateColumns = false;
            this.komorkaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.komorkaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.komorkaDataGridView.DataSource = this.komorkaBindingSource;
            this.komorkaDataGridView.Location = new System.Drawing.Point(4, 0);
            this.komorkaDataGridView.Name = "komorkaDataGridView";
            this.komorkaDataGridView.Size = new System.Drawing.Size(644, 264);
            this.komorkaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_komorka";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_komorka";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn8.HeaderText = "model";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "waga";
            this.dataGridViewTextBoxColumn9.HeaderText = "waga";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "cena";
            this.dataGridViewTextBoxColumn10.HeaderText = "cena";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "id_osoba";
            this.dataGridViewTextBoxColumn11.HeaderText = "id_osoba";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "id_marka";
            this.dataGridViewTextBoxColumn12.HeaderText = "id_marka";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Offlina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 350);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.markaBindingNavigator);
            this.Name = "Offlina";
            this.Text = "Offlina";
            this.Load += new System.EventHandler(this.Offlina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingNavigator)).EndInit();
            this.markaBindingNavigator.ResumeLayout(false);
            this.markaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markaDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Osoba.ResumeLayout(false);
            this.Marka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaDataGridView)).EndInit();
            this.komorki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.komorkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komorkaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource markaBindingSource;
        private DataSet2TableAdapters.markaTableAdapter markaTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator markaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton markaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView markaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataSet2TableAdapters.osobaTableAdapter osobaTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Osoba;
        private System.Windows.Forms.TabPage Marka;
        private System.Windows.Forms.BindingSource osobaBindingSource;
        private System.Windows.Forms.DataGridView osobaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataSet2TableAdapters.komorkaTableAdapter komorkaTableAdapter;
        private System.Windows.Forms.TabPage komorki;
        private System.Windows.Forms.BindingSource komorkaBindingSource;
        private System.Windows.Forms.DataGridView komorkaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button4;
    }
}