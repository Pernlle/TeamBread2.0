
namespace Semesterprojektet
{
    partial class CRUDKunder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tHEDATASETOFALL = new Semesterprojektet.tHEDATASETOFALL();
            this.kunderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kunderTableAdapter = new Semesterprojektet.tHEDATASETOFALLTableAdapters.KunderTableAdapter();
            this.kIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saelgerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.koeberDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.opretBtn = new System.Windows.Forms.Button();
            this.opdaterBtn = new System.Windows.Forms.Button();
            this.sletBtn = new System.Windows.Forms.Button();
            this.fNavnBox = new System.Windows.Forms.TextBox();
            this.eNavnBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.koeberCheck = new System.Windows.Forms.CheckBox();
            this.saeglerCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kunderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saeglerCheck);
            this.panel1.Controls.Add(this.koeberCheck);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.eNavnBox);
            this.panel1.Controls.Add(this.fNavnBox);
            this.panel1.Controls.Add(this.sletBtn);
            this.panel1.Controls.Add(this.opdaterBtn);
            this.panel1.Controls.Add(this.opretBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 152);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 298);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kIDDataGridViewTextBoxColumn,
            this.fNavnDataGridViewTextBoxColumn,
            this.eNavnDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.saelgerDataGridViewCheckBoxColumn,
            this.koeberDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.kunderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // tHEDATASETOFALL
            // 
            this.tHEDATASETOFALL.DataSetName = "tHEDATASETOFALL";
            this.tHEDATASETOFALL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kunderBindingSource
            // 
            this.kunderBindingSource.DataMember = "Kunder";
            this.kunderBindingSource.DataSource = this.tHEDATASETOFALL;
            // 
            // kunderTableAdapter
            // 
            this.kunderTableAdapter.ClearBeforeFill = true;
            // 
            // kIDDataGridViewTextBoxColumn
            // 
            this.kIDDataGridViewTextBoxColumn.DataPropertyName = "kID";
            this.kIDDataGridViewTextBoxColumn.HeaderText = "kID";
            this.kIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kIDDataGridViewTextBoxColumn.Name = "kIDDataGridViewTextBoxColumn";
            this.kIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNavnDataGridViewTextBoxColumn
            // 
            this.fNavnDataGridViewTextBoxColumn.DataPropertyName = "fNavn";
            this.fNavnDataGridViewTextBoxColumn.HeaderText = "fNavn";
            this.fNavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fNavnDataGridViewTextBoxColumn.Name = "fNavnDataGridViewTextBoxColumn";
            // 
            // eNavnDataGridViewTextBoxColumn
            // 
            this.eNavnDataGridViewTextBoxColumn.DataPropertyName = "eNavn";
            this.eNavnDataGridViewTextBoxColumn.HeaderText = "eNavn";
            this.eNavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eNavnDataGridViewTextBoxColumn.Name = "eNavnDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // saelgerDataGridViewCheckBoxColumn
            // 
            this.saelgerDataGridViewCheckBoxColumn.DataPropertyName = "saelger";
            this.saelgerDataGridViewCheckBoxColumn.HeaderText = "saelger";
            this.saelgerDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.saelgerDataGridViewCheckBoxColumn.Name = "saelgerDataGridViewCheckBoxColumn";
            // 
            // koeberDataGridViewCheckBoxColumn
            // 
            this.koeberDataGridViewCheckBoxColumn.DataPropertyName = "koeber";
            this.koeberDataGridViewCheckBoxColumn.HeaderText = "koeber";
            this.koeberDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.koeberDataGridViewCheckBoxColumn.Name = "koeberDataGridViewCheckBoxColumn";
            // 
            // opretBtn
            // 
            this.opretBtn.Location = new System.Drawing.Point(669, 25);
            this.opretBtn.Name = "opretBtn";
            this.opretBtn.Size = new System.Drawing.Size(101, 27);
            this.opretBtn.TabIndex = 0;
            this.opretBtn.Text = "Opret";
            this.opretBtn.UseVisualStyleBackColor = true;
            this.opretBtn.Click += new System.EventHandler(this.opretBtn_Click);
            // 
            // opdaterBtn
            // 
            this.opdaterBtn.Location = new System.Drawing.Point(669, 58);
            this.opdaterBtn.Name = "opdaterBtn";
            this.opdaterBtn.Size = new System.Drawing.Size(101, 27);
            this.opdaterBtn.TabIndex = 1;
            this.opdaterBtn.Text = "Opdater";
            this.opdaterBtn.UseVisualStyleBackColor = true;
            this.opdaterBtn.Click += new System.EventHandler(this.opdaterBtn_Click);
            // 
            // sletBtn
            // 
            this.sletBtn.Location = new System.Drawing.Point(669, 92);
            this.sletBtn.Name = "sletBtn";
            this.sletBtn.Size = new System.Drawing.Size(101, 27);
            this.sletBtn.TabIndex = 2;
            this.sletBtn.Text = "Slet";
            this.sletBtn.UseVisualStyleBackColor = true;
            this.sletBtn.Click += new System.EventHandler(this.sletBtn_Click);
            // 
            // fNavnBox
            // 
            this.fNavnBox.Location = new System.Drawing.Point(103, 39);
            this.fNavnBox.Name = "fNavnBox";
            this.fNavnBox.Size = new System.Drawing.Size(100, 26);
            this.fNavnBox.TabIndex = 3;
            this.fNavnBox.TextChanged += new System.EventHandler(this.fNavnBox_TextChanged);
            // 
            // eNavnBox
            // 
            this.eNavnBox.Location = new System.Drawing.Point(103, 96);
            this.eNavnBox.Name = "eNavnBox";
            this.eNavnBox.Size = new System.Drawing.Size(100, 26);
            this.eNavnBox.TabIndex = 4;
            this.eNavnBox.TextChanged += new System.EventHandler(this.eNavnBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(304, 39);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 26);
            this.emailBox.TabIndex = 5;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // koeberCheck
            // 
            this.koeberCheck.AutoSize = true;
            this.koeberCheck.Location = new System.Drawing.Point(327, 98);
            this.koeberCheck.Name = "koeberCheck";
            this.koeberCheck.Size = new System.Drawing.Size(77, 24);
            this.koeberCheck.TabIndex = 7;
            this.koeberCheck.Text = "Køber";
            this.koeberCheck.UseVisualStyleBackColor = true;
            this.koeberCheck.CheckedChanged += new System.EventHandler(this.koeberCheck_CheckedChanged);
            // 
            // saeglerCheck
            // 
            this.saeglerCheck.AutoSize = true;
            this.saeglerCheck.Location = new System.Drawing.Point(234, 98);
            this.saeglerCheck.Name = "saeglerCheck";
            this.saeglerCheck.Size = new System.Drawing.Size(87, 24);
            this.saeglerCheck.TabIndex = 8;
            this.saeglerCheck.Text = "Sælger";
            this.saeglerCheck.UseVisualStyleBackColor = true;
            this.saeglerCheck.CheckedChanged += new System.EventHandler(this.saeglerCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fornavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Efternavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // CRUDKunder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDKunder";
            this.Text = "CRUDKunder";
            this.Load += new System.EventHandler(this.CRUDKunder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kunderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tHEDATASETOFALL tHEDATASETOFALL;
        private System.Windows.Forms.BindingSource kunderBindingSource;
        private tHEDATASETOFALLTableAdapters.KunderTableAdapter kunderTableAdapter;
        private System.Windows.Forms.Button sletBtn;
        private System.Windows.Forms.Button opdaterBtn;
        private System.Windows.Forms.Button opretBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn saelgerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn koeberDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox saeglerCheck;
        private System.Windows.Forms.CheckBox koeberCheck;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox eNavnBox;
        private System.Windows.Forms.TextBox fNavnBox;
    }
}