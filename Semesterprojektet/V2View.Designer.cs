
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSearchPostNr = new System.Windows.Forms.ComboBox();
            this.boligBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tHEDATASETOFALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHEDATASETOFALL = new Semesterprojektet.tHEDATASETOFALL();
            this.dgv1 = new System.Windows.Forms.DataGridView();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.cbSearchPostNr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 64);
            this.panel1.TabIndex = 0;
            // 
            // cbSearchPostNr
            // 
            this.cbSearchPostNr.DataSource = this.boligBindingSource1;
            this.cbSearchPostNr.DisplayMember = "postNr";
            this.cbSearchPostNr.FormattingEnabled = true;
            this.cbSearchPostNr.Location = new System.Drawing.Point(110, 22);
            this.cbSearchPostNr.Name = "cbSearchPostNr";
            this.cbSearchPostNr.Size = new System.Drawing.Size(154, 24);
            this.cbSearchPostNr.TabIndex = 0;
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
            // dgv1
            // 
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv1.DataSource = this.boligBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.GridColor = System.Drawing.Color.Silver;
            this.dgv1.Location = new System.Drawing.Point(0, 64);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(836, 399);
            this.dgv1.TabIndex = 1;
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
            // V2View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 463);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "V2View";
            this.Text = "V2View";
            this.Load += new System.EventHandler(this.V2View_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv1;
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
    }
}