
namespace Semesterprojektet
{
    partial class V2View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datobox2 = new System.Windows.Forms.TextBox();
            this.datobox1 = new System.Windows.Forms.TextBox();
            this.prisInput = new System.Windows.Forms.TextBox();
            this.prisSearch = new System.Windows.Forms.Button();
            this.mlDatoer = new System.Windows.Forms.Button();
            this.datoslutbox = new System.Windows.Forms.DateTimePicker();
            this.datostartbox = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.print = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.cbSearchPostNr = new System.Windows.Forms.ComboBox();
            this.boligBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tHEDATASETOFALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHEDATASETOFALL = new Semesterprojektet.tHEDATASETOFALL();
            this.clear = new System.Windows.Forms.Button();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solgtDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salgsPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handelsPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handelsDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saeglerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koeberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boligTableAdapter = new Semesterprojektet.tHEDATASETOFALLTableAdapters.BoligTableAdapter();
            this.dgvK = new System.Windows.Forms.DataGridView();
            this.kIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saelgerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.koeberDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kunderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kunderTableAdapter = new Semesterprojektet.tHEDATASETOFALLTableAdapters.KunderTableAdapter();
            this.dgvSD = new System.Windows.Forms.DataGridView();
            this.boligBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kunderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbSearchPostNr);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 130);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.datobox2);
            this.panel3.Controls.Add(this.datobox1);
            this.panel3.Controls.Add(this.prisInput);
            this.panel3.Controls.Add(this.prisSearch);
            this.panel3.Controls.Add(this.mlDatoer);
            this.panel3.Controls.Add(this.datoslutbox);
            this.panel3.Controls.Add(this.datostartbox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 130);
            this.panel3.TabIndex = 5;
            // 
            // datobox2
            // 
            this.datobox2.Location = new System.Drawing.Point(17, 65);
            this.datobox2.Name = "datobox2";
            this.datobox2.Size = new System.Drawing.Size(200, 26);
            this.datobox2.TabIndex = 6;
            // 
            // datobox1
            // 
            this.datobox1.Location = new System.Drawing.Point(17, 28);
            this.datobox1.Name = "datobox1";
            this.datobox1.Size = new System.Drawing.Size(200, 26);
            this.datobox1.TabIndex = 5;
            // 
            // prisInput
            // 
            this.prisInput.Location = new System.Drawing.Point(341, 18);
            this.prisInput.Name = "prisInput";
            this.prisInput.Size = new System.Drawing.Size(100, 26);
            this.prisInput.TabIndex = 4;
            // 
            // prisSearch
            // 
            this.prisSearch.Location = new System.Drawing.Point(467, 37);
            this.prisSearch.Name = "prisSearch";
            this.prisSearch.Size = new System.Drawing.Size(75, 41);
            this.prisSearch.TabIndex = 3;
            this.prisSearch.Text = "Søg";
            this.prisSearch.UseVisualStyleBackColor = true;
            this.prisSearch.Click += new System.EventHandler(this.prisSearch_Click);
            // 
            // mlDatoer
            // 
            this.mlDatoer.Location = new System.Drawing.Point(240, 41);
            this.mlDatoer.Name = "mlDatoer";
            this.mlDatoer.Size = new System.Drawing.Size(75, 37);
            this.mlDatoer.TabIndex = 2;
            this.mlDatoer.Text = "Søg";
            this.mlDatoer.UseVisualStyleBackColor = true;
            this.mlDatoer.Click += new System.EventHandler(this.mlDatoer_Click);
            // 
            // datoslutbox
            // 
            this.datoslutbox.Location = new System.Drawing.Point(17, 66);
            this.datoslutbox.Name = "datoslutbox";
            this.datoslutbox.Size = new System.Drawing.Size(200, 26);
            this.datoslutbox.TabIndex = 1;
            // 
            // datostartbox
            // 
            this.datostartbox.Location = new System.Drawing.Point(17, 28);
            this.datostartbox.Name = "datostartbox";
            this.datostartbox.Size = new System.Drawing.Size(200, 26);
            this.datostartbox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.print);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1159, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 130);
            this.panel2.TabIndex = 4;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.White;
            this.print.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(38, 32);
            this.print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(124, 45);
            this.print.TabIndex = 1;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(88, 42);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(28, 26);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.Visible = false;
            // 
            // cbSearchPostNr
            // 
            this.cbSearchPostNr.DataSource = this.boligBindingSource1;
            this.cbSearchPostNr.DisplayMember = "postNr";
            this.cbSearchPostNr.FormattingEnabled = true;
            this.cbSearchPostNr.Location = new System.Drawing.Point(819, 30);
            this.cbSearchPostNr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSearchPostNr.Name = "cbSearchPostNr";
            this.cbSearchPostNr.Size = new System.Drawing.Size(122, 28);
            this.cbSearchPostNr.TabIndex = 3;
            this.cbSearchPostNr.ValueMember = "postNr";
            this.cbSearchPostNr.SelectedIndexChanged += new System.EventHandler(this.cbSearchPostNr_SelectedIndexChanged);
            // 
            // boligBindingSource1
            // 
            this.boligBindingSource1.DataMember = "Bolig";
            this.boligBindingSource1.DataSource = this.tHEDATASETOFALLBindingSource;
            // 
            // tHEDATASETOFALLBindingSource
            // 
            this.tHEDATASETOFALLBindingSource.DataSource = this.tHEDATASETOFALL;
            this.tHEDATASETOFALLBindingSource.Position = 0;
            // 
            // tHEDATASETOFALL
            // 
            this.tHEDATASETOFALL.DataSetName = "tHEDATASETOFALL";
            this.tHEDATASETOFALL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.White;
            this.clear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(947, 13);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(133, 45);
            this.clear.TabIndex = 2;
            this.clear.Text = "Slet søgning";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // dgvB
            // 
            this.dgvB.AutoGenerateColumns = false;
            this.dgvB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.postNrDataGridViewTextBoxColumn,
            this.solgtDataGridViewCheckBoxColumn,
            this.kvmDataGridViewTextBoxColumn,
            this.salgsPrisDataGridViewTextBoxColumn,
            this.handelsPrisDataGridViewTextBoxColumn,
            this.handelsDatoDataGridViewTextBoxColumn,
            this.eIDDataGridViewTextBoxColumn,
            this.saeglerIDDataGridViewTextBoxColumn,
            this.koeberIDDataGridViewTextBoxColumn});
            this.dgvB.DataSource = this.boligBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvB.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvB.GridColor = System.Drawing.Color.Silver;
            this.dgvB.Location = new System.Drawing.Point(0, 130);
            this.dgvB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvB.Name = "dgvB";
            this.dgvB.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvB.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvB.RowTemplate.Height = 24;
            this.dgvB.Size = new System.Drawing.Size(1350, 546);
            this.dgvB.TabIndex = 1;
            this.dgvB.TabStop = false;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "bID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "bID";
            this.bIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // postNrDataGridViewTextBoxColumn
            // 
            this.postNrDataGridViewTextBoxColumn.DataPropertyName = "postNr";
            this.postNrDataGridViewTextBoxColumn.HeaderText = "postNr";
            this.postNrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postNrDataGridViewTextBoxColumn.Name = "postNrDataGridViewTextBoxColumn";
            // 
            // solgtDataGridViewCheckBoxColumn
            // 
            this.solgtDataGridViewCheckBoxColumn.DataPropertyName = "solgt";
            this.solgtDataGridViewCheckBoxColumn.HeaderText = "solgt";
            this.solgtDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.solgtDataGridViewCheckBoxColumn.Name = "solgtDataGridViewCheckBoxColumn";
            // 
            // kvmDataGridViewTextBoxColumn
            // 
            this.kvmDataGridViewTextBoxColumn.DataPropertyName = "kvm";
            this.kvmDataGridViewTextBoxColumn.HeaderText = "kvm";
            this.kvmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kvmDataGridViewTextBoxColumn.Name = "kvmDataGridViewTextBoxColumn";
            // 
            // salgsPrisDataGridViewTextBoxColumn
            // 
            this.salgsPrisDataGridViewTextBoxColumn.DataPropertyName = "salgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.HeaderText = "salgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salgsPrisDataGridViewTextBoxColumn.Name = "salgsPrisDataGridViewTextBoxColumn";
            // 
            // handelsPrisDataGridViewTextBoxColumn
            // 
            this.handelsPrisDataGridViewTextBoxColumn.DataPropertyName = "handelsPris";
            this.handelsPrisDataGridViewTextBoxColumn.HeaderText = "handelsPris";
            this.handelsPrisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.handelsPrisDataGridViewTextBoxColumn.Name = "handelsPrisDataGridViewTextBoxColumn";
            // 
            // handelsDatoDataGridViewTextBoxColumn
            // 
            this.handelsDatoDataGridViewTextBoxColumn.DataPropertyName = "handelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.HeaderText = "handelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.handelsDatoDataGridViewTextBoxColumn.Name = "handelsDatoDataGridViewTextBoxColumn";
            // 
            // eIDDataGridViewTextBoxColumn
            // 
            this.eIDDataGridViewTextBoxColumn.DataPropertyName = "eID";
            this.eIDDataGridViewTextBoxColumn.HeaderText = "eID";
            this.eIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eIDDataGridViewTextBoxColumn.Name = "eIDDataGridViewTextBoxColumn";
            // 
            // saeglerIDDataGridViewTextBoxColumn
            // 
            this.saeglerIDDataGridViewTextBoxColumn.DataPropertyName = "saeglerID";
            this.saeglerIDDataGridViewTextBoxColumn.HeaderText = "saeglerID";
            this.saeglerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saeglerIDDataGridViewTextBoxColumn.Name = "saeglerIDDataGridViewTextBoxColumn";
            // 
            // koeberIDDataGridViewTextBoxColumn
            // 
            this.koeberIDDataGridViewTextBoxColumn.DataPropertyName = "koeberID";
            this.koeberIDDataGridViewTextBoxColumn.HeaderText = "koeberID";
            this.koeberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.koeberIDDataGridViewTextBoxColumn.Name = "koeberIDDataGridViewTextBoxColumn";
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            this.boligBindingSource.DataSource = this.tHEDATASETOFALLBindingSource;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // dgvK
            // 
            this.dgvK.AutoGenerateColumns = false;
            this.dgvK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.dgvK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kIDDataGridViewTextBoxColumn,
            this.fNavnDataGridViewTextBoxColumn,
            this.eNavnDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.saelgerDataGridViewCheckBoxColumn,
            this.koeberDataGridViewCheckBoxColumn});
            this.dgvK.DataSource = this.kunderBindingSource;
            this.dgvK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvK.GridColor = System.Drawing.Color.White;
            this.dgvK.Location = new System.Drawing.Point(0, 487);
            this.dgvK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvK.Name = "dgvK";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvK.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvK.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvK.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvK.RowTemplate.Height = 24;
            this.dgvK.Size = new System.Drawing.Size(1350, 189);
            this.dgvK.TabIndex = 2;
            this.dgvK.TabStop = false;
            // 
            // kIDDataGridViewTextBoxColumn
            // 
            this.kIDDataGridViewTextBoxColumn.DataPropertyName = "kID";
            this.kIDDataGridViewTextBoxColumn.HeaderText = "kID";
            this.kIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kIDDataGridViewTextBoxColumn.Name = "kIDDataGridViewTextBoxColumn";
            this.kIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNavnDataGridViewTextBoxColumn
            // 
            this.fNavnDataGridViewTextBoxColumn.DataPropertyName = "fNavn";
            this.fNavnDataGridViewTextBoxColumn.HeaderText = "fNavn";
            this.fNavnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNavnDataGridViewTextBoxColumn.Name = "fNavnDataGridViewTextBoxColumn";
            // 
            // eNavnDataGridViewTextBoxColumn
            // 
            this.eNavnDataGridViewTextBoxColumn.DataPropertyName = "eNavn";
            this.eNavnDataGridViewTextBoxColumn.HeaderText = "eNavn";
            this.eNavnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eNavnDataGridViewTextBoxColumn.Name = "eNavnDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // saelgerDataGridViewCheckBoxColumn
            // 
            this.saelgerDataGridViewCheckBoxColumn.DataPropertyName = "saelger";
            this.saelgerDataGridViewCheckBoxColumn.HeaderText = "saelger";
            this.saelgerDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.saelgerDataGridViewCheckBoxColumn.Name = "saelgerDataGridViewCheckBoxColumn";
            // 
            // koeberDataGridViewCheckBoxColumn
            // 
            this.koeberDataGridViewCheckBoxColumn.DataPropertyName = "koeber";
            this.koeberDataGridViewCheckBoxColumn.HeaderText = "koeber";
            this.koeberDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.koeberDataGridViewCheckBoxColumn.Name = "koeberDataGridViewCheckBoxColumn";
            // 
            // kunderBindingSource
            // 
            this.kunderBindingSource.DataMember = "Kunder";
            this.kunderBindingSource.DataSource = this.tHEDATASETOFALLBindingSource;
            // 
            // kunderTableAdapter
            // 
            this.kunderTableAdapter.ClearBeforeFill = true;
            // 
            // dgvSD
            // 
            this.dgvSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSD.Location = new System.Drawing.Point(388, 574);
            this.dgvSD.Name = "dgvSD";
            this.dgvSD.RowHeadersWidth = 62;
            this.dgvSD.RowTemplate.Height = 28;
            this.dgvSD.Size = new System.Drawing.Size(41, 90);
            this.dgvSD.TabIndex = 3;
            // 
            // boligBindingSource2
            // 
            this.boligBindingSource2.DataMember = "Bolig";
            this.boligBindingSource2.DataSource = this.tHEDATASETOFALLBindingSource;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1350, 676);
            this.panel4.TabIndex = 4;
            // 
            // V2View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1350, 676);
            this.Controls.Add(this.dgvK);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSD);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "V2View";
            this.Text = "V2View";
            this.Load += new System.EventHandler(this.V2View_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kunderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.BindingSource tHEDATASETOFALLBindingSource;
        private tHEDATASETOFALL tHEDATASETOFALL;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private tHEDATASETOFALLTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn solgtDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handelsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handelsDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saeglerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koeberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbSearchPostNr;
        private System.Windows.Forms.BindingSource boligBindingSource1;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvK;
        private System.Windows.Forms.BindingSource kunderBindingSource;
        private tHEDATASETOFALLTableAdapters.KunderTableAdapter kunderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn saelgerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn koeberDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button mlDatoer;
        private System.Windows.Forms.DateTimePicker datoslutbox;
        private System.Windows.Forms.DateTimePicker datostartbox;
        private System.Windows.Forms.DataGridView dgvSD;
        private System.Windows.Forms.BindingSource boligBindingSource2;
        private System.Windows.Forms.TextBox prisInput;
        private System.Windows.Forms.Button prisSearch;
        private System.Windows.Forms.TextBox datobox2;
        private System.Windows.Forms.TextBox datobox1;
        private System.Windows.Forms.Panel panel4;
    }
}