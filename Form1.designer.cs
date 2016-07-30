namespace Sklep_internetowy_wersja_graf
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileGenerator = new System.Windows.Forms.Button();
            this.NazwaCheckbox = new System.Windows.Forms.CheckBox();
            this.CenaCheckbox = new System.Windows.Forms.CheckBox();
            this.IloscCheckbox = new System.Windows.Forms.CheckBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.updateGroupBox = new System.Windows.Forms.GroupBox();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.updateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.idDataGridViewTextBoxColumn,
            this.name,
            this.modelDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.skuDataGridViewTextBoxColumn,
            this.upcDataGridViewTextBoxColumn,
            this.dateavailableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produktBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(872, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // FileGenerator
            // 
            this.FileGenerator.Location = new System.Drawing.Point(375, 344);
            this.FileGenerator.Name = "FileGenerator";
            this.FileGenerator.Size = new System.Drawing.Size(113, 20);
            this.FileGenerator.TabIndex = 2;
            this.FileGenerator.Text = "WYGENERUJ PLIK";
            this.FileGenerator.UseVisualStyleBackColor = true;
            this.FileGenerator.Visible = false;
            this.FileGenerator.Click += new System.EventHandler(this.button1_Click);
            // 
            // NazwaCheckbox
            // 
            this.NazwaCheckbox.AutoSize = true;
            this.NazwaCheckbox.Checked = true;
            this.NazwaCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NazwaCheckbox.Location = new System.Drawing.Point(6, 19);
            this.NazwaCheckbox.Name = "NazwaCheckbox";
            this.NazwaCheckbox.Size = new System.Drawing.Size(59, 17);
            this.NazwaCheckbox.TabIndex = 5;
            this.NazwaCheckbox.Text = "Nazwa";
            this.NazwaCheckbox.UseVisualStyleBackColor = true;
            this.NazwaCheckbox.CheckedChanged += new System.EventHandler(this.NazwaCheckbox_CheckedChanged);
            // 
            // CenaCheckbox
            // 
            this.CenaCheckbox.AutoSize = true;
            this.CenaCheckbox.Checked = true;
            this.CenaCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CenaCheckbox.Location = new System.Drawing.Point(6, 42);
            this.CenaCheckbox.Name = "CenaCheckbox";
            this.CenaCheckbox.Size = new System.Drawing.Size(51, 17);
            this.CenaCheckbox.TabIndex = 6;
            this.CenaCheckbox.Text = "Cena";
            this.CenaCheckbox.UseVisualStyleBackColor = true;
            this.CenaCheckbox.CheckedChanged += new System.EventHandler(this.CenaCheckbox_CheckedChanged);
            // 
            // IloscCheckbox
            // 
            this.IloscCheckbox.AutoSize = true;
            this.IloscCheckbox.Checked = true;
            this.IloscCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IloscCheckbox.Location = new System.Drawing.Point(6, 65);
            this.IloscCheckbox.Name = "IloscCheckbox";
            this.IloscCheckbox.Size = new System.Drawing.Size(48, 17);
            this.IloscCheckbox.TabIndex = 7;
            this.IloscCheckbox.Text = "Ilość";
            this.IloscCheckbox.UseVisualStyleBackColor = true;
            this.IloscCheckbox.CheckedChanged += new System.EventHandler(this.IloscCheckbox_CheckedChanged);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(112, 19);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(113, 63);
            this.Updatebutton.TabIndex = 8;
            this.Updatebutton.Text = "Zaktualizuj listę";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(256, 251);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 20);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Szukaj";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 251);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(238, 20);
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // updateGroupBox
            // 
            this.updateGroupBox.Controls.Add(this.NazwaCheckbox);
            this.updateGroupBox.Controls.Add(this.CenaCheckbox);
            this.updateGroupBox.Controls.Add(this.IloscCheckbox);
            this.updateGroupBox.Controls.Add(this.Updatebutton);
            this.updateGroupBox.Location = new System.Drawing.Point(644, 264);
            this.updateGroupBox.Name = "updateGroupBox";
            this.updateGroupBox.Size = new System.Drawing.Size(240, 100);
            this.updateGroupBox.TabIndex = 11;
            this.updateGroupBox.TabStop = false;
            this.updateGroupBox.Text = "Zaktualizuj:";
            this.updateGroupBox.Visible = false;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataSource = typeof(Sklep_internetowy_wersja_graf.Produkt);
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Width = 50;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nazwa";
            this.name.Name = "name";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Visible = false;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 60;
            // 
            // skuDataGridViewTextBoxColumn
            // 
            this.skuDataGridViewTextBoxColumn.DataPropertyName = "sku";
            this.skuDataGridViewTextBoxColumn.HeaderText = "Cena Sklepowa";
            this.skuDataGridViewTextBoxColumn.Name = "skuDataGridViewTextBoxColumn";
            this.skuDataGridViewTextBoxColumn.Width = 110;
            // 
            // upcDataGridViewTextBoxColumn
            // 
            this.upcDataGridViewTextBoxColumn.DataPropertyName = "upc";
            this.upcDataGridViewTextBoxColumn.HeaderText = "Cena Sklepowa z VAT";
            this.upcDataGridViewTextBoxColumn.Name = "upcDataGridViewTextBoxColumn";
            this.upcDataGridViewTextBoxColumn.Width = 140;
            // 
            // dateavailableDataGridViewTextBoxColumn
            // 
            this.dateavailableDataGridViewTextBoxColumn.DataPropertyName = "date_available";
            this.dateavailableDataGridViewTextBoxColumn.HeaderText = "Dostępny od";
            this.dateavailableDataGridViewTextBoxColumn.Name = "dateavailableDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 397);
            this.Controls.Add(this.updateGroupBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.FileGenerator);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "InstalTerm Updater";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.updateGroupBox.ResumeLayout(false);
            this.updateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FileGenerator;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private System.Windows.Forms.CheckBox NazwaCheckbox;
        private System.Windows.Forms.CheckBox CenaCheckbox;
        private System.Windows.Forms.CheckBox IloscCheckbox;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox updateGroupBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateavailableDataGridViewTextBoxColumn;

    }
}

