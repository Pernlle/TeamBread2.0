
namespace Semesterprojektet
{
    partial class View
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamBreadDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamBreadDBDataSet = new Semesterprojektet.TeamBreadDBDataSet();
            this.boligTableAdapter = new Semesterprojektet.TeamBreadDBDataSetTableAdapters.BoligTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.boligBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boligBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tHEONETHEONLY = new Semesterprojektet.THEONETHEONLY();
            this.tHEONETHEONLYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boligBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.boligTableAdapter1 = new Semesterprojektet.THEONETHEONLYTableAdapters.BoligTableAdapter();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salgsPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handelsPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handelsDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solgtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBreadDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBreadDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEONETHEONLY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEONETHEONLYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.eIDDataGridViewTextBoxColumn,
            this.kIDDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.postNrDataGridViewTextBoxColumn,
            this.kvmDataGridViewTextBoxColumn,
            this.salgsPrisDataGridViewTextBoxColumn,
            this.handelsPrisDataGridViewTextBoxColumn,
            this.handelsDatoDataGridViewTextBoxColumn,
            this.solgtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boligBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(17, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(845, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            this.boligBindingSource.DataSource = this.teamBreadDBDataSetBindingSource;
            // 
            // teamBreadDBDataSetBindingSource
            // 
            this.teamBreadDBDataSetBindingSource.DataSource = this.teamBreadDBDataSet;
            this.teamBreadDBDataSetBindingSource.Position = 0;
            // 
            // teamBreadDBDataSet
            // 
            this.teamBreadDBDataSet.DataSetName = "TeamBreadDBDataSet";
            this.teamBreadDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 542);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 361);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Søg";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(374, 370);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Postnummer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Søg på boliger i hele Danmark";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print Sheet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boligBindingSource1
            // 
            this.boligBindingSource1.DataMember = "Bolig";
            this.boligBindingSource1.DataSource = this.teamBreadDBDataSetBindingSource;
            // 
            // boligBindingSource2
            // 
            this.boligBindingSource2.DataMember = "Bolig";
            this.boligBindingSource2.DataSource = this.teamBreadDBDataSetBindingSource;
            // 
            // tHEONETHEONLY
            // 
            this.tHEONETHEONLY.DataSetName = "THEONETHEONLY";
            this.tHEONETHEONLY.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHEONETHEONLYBindingSource
            // 
            this.tHEONETHEONLYBindingSource.DataSource = this.tHEONETHEONLY;
            this.tHEONETHEONLYBindingSource.Position = 0;
            // 
            // boligBindingSource3
            // 
            this.boligBindingSource3.DataMember = "Bolig";
            this.boligBindingSource3.DataSource = this.tHEONETHEONLYBindingSource;
            // 
            // boligTableAdapter1
            // 
            this.boligTableAdapter1.ClearBeforeFill = true;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "bID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "bID";
            this.bIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // eIDDataGridViewTextBoxColumn
            // 
            this.eIDDataGridViewTextBoxColumn.DataPropertyName = "eID";
            this.eIDDataGridViewTextBoxColumn.HeaderText = "eID";
            this.eIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eIDDataGridViewTextBoxColumn.Name = "eIDDataGridViewTextBoxColumn";
            this.eIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // kIDDataGridViewTextBoxColumn
            // 
            this.kIDDataGridViewTextBoxColumn.DataPropertyName = "kID";
            this.kIDDataGridViewTextBoxColumn.HeaderText = "kID";
            this.kIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kIDDataGridViewTextBoxColumn.Name = "kIDDataGridViewTextBoxColumn";
            this.kIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.Width = 150;
            // 
            // postNrDataGridViewTextBoxColumn
            // 
            this.postNrDataGridViewTextBoxColumn.DataPropertyName = "postNr";
            this.postNrDataGridViewTextBoxColumn.HeaderText = "postNr";
            this.postNrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postNrDataGridViewTextBoxColumn.Name = "postNrDataGridViewTextBoxColumn";
            this.postNrDataGridViewTextBoxColumn.Width = 150;
            // 
            // kvmDataGridViewTextBoxColumn
            // 
            this.kvmDataGridViewTextBoxColumn.DataPropertyName = "kvm";
            this.kvmDataGridViewTextBoxColumn.HeaderText = "kvm";
            this.kvmDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kvmDataGridViewTextBoxColumn.Name = "kvmDataGridViewTextBoxColumn";
            this.kvmDataGridViewTextBoxColumn.Width = 150;
            // 
            // salgsPrisDataGridViewTextBoxColumn
            // 
            this.salgsPrisDataGridViewTextBoxColumn.DataPropertyName = "salgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.HeaderText = "salgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salgsPrisDataGridViewTextBoxColumn.Name = "salgsPrisDataGridViewTextBoxColumn";
            this.salgsPrisDataGridViewTextBoxColumn.Width = 150;
            // 
            // handelsPrisDataGridViewTextBoxColumn
            // 
            this.handelsPrisDataGridViewTextBoxColumn.DataPropertyName = "handelsPris";
            this.handelsPrisDataGridViewTextBoxColumn.HeaderText = "handelsPris";
            this.handelsPrisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.handelsPrisDataGridViewTextBoxColumn.Name = "handelsPrisDataGridViewTextBoxColumn";
            this.handelsPrisDataGridViewTextBoxColumn.Width = 150;
            // 
            // handelsDatoDataGridViewTextBoxColumn
            // 
            this.handelsDatoDataGridViewTextBoxColumn.DataPropertyName = "handelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.HeaderText = "handelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.handelsDatoDataGridViewTextBoxColumn.Name = "handelsDatoDataGridViewTextBoxColumn";
            this.handelsDatoDataGridViewTextBoxColumn.Width = 150;
            // 
            // solgtDataGridViewTextBoxColumn
            // 
            this.solgtDataGridViewTextBoxColumn.DataPropertyName = "solgt";
            this.solgtDataGridViewTextBoxColumn.HeaderText = "solgt";
            this.solgtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.solgtDataGridViewTextBoxColumn.Name = "solgtDataGridViewTextBoxColumn";
            this.solgtDataGridViewTextBoxColumn.Width = 150;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBreadDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBreadDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEONETHEONLY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEONETHEONLYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource teamBreadDBDataSetBindingSource;
        private TeamBreadDBDataSet teamBreadDBDataSet;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private TeamBreadDBDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource boligBindingSource2;
        private System.Windows.Forms.BindingSource boligBindingSource1;
        private System.Windows.Forms.BindingSource tHEONETHEONLYBindingSource;
        private THEONETHEONLY tHEONETHEONLY;
        private System.Windows.Forms.BindingSource boligBindingSource3;
        private THEONETHEONLYTableAdapters.BoligTableAdapter boligTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handelsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handelsDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solgtDataGridViewTextBoxColumn;
    }
}