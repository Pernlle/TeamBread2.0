﻿
namespace Semesterprojektet
{
    partial class V2CRUDBolig
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
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solgtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salgsPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handelsPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handelsDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHEONETHEONLY = new Semesterprojektet.THEONETHEONLY();
            this.boligTableAdapter = new Semesterprojektet.THEONETHEONLYTableAdapters.BoligTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.soldCheck = new System.Windows.Forms.CheckBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.salgspris = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.kvm = new System.Windows.Forms.TextBox();
            this.handelspris = new System.Windows.Forms.TextBox();
            this.sID = new System.Windows.Forms.TextBox();
            this.eID = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.handelsdato = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEONETHEONLY)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIDDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.postNrDataGridViewTextBoxColumn,
            this.solgtDataGridViewTextBoxColumn,
            this.kvmDataGridViewTextBoxColumn,
            this.salgsPrisDataGridViewTextBoxColumn,
            this.handelsPrisDataGridViewTextBoxColumn,
            this.handelsDatoDataGridViewTextBoxColumn,
            this.kIDDataGridViewTextBoxColumn,
            this.eIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boligBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "bID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "bID";
            this.bIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // postNrDataGridViewTextBoxColumn
            // 
            this.postNrDataGridViewTextBoxColumn.DataPropertyName = "postNr";
            this.postNrDataGridViewTextBoxColumn.HeaderText = "postNr";
            this.postNrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postNrDataGridViewTextBoxColumn.Name = "postNrDataGridViewTextBoxColumn";
            // 
            // solgtDataGridViewTextBoxColumn
            // 
            this.solgtDataGridViewTextBoxColumn.DataPropertyName = "solgt";
            this.solgtDataGridViewTextBoxColumn.HeaderText = "solgt";
            this.solgtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.solgtDataGridViewTextBoxColumn.Name = "solgtDataGridViewTextBoxColumn";
            // 
            // kvmDataGridViewTextBoxColumn
            // 
            this.kvmDataGridViewTextBoxColumn.DataPropertyName = "kvm";
            this.kvmDataGridViewTextBoxColumn.HeaderText = "kvm";
            this.kvmDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kvmDataGridViewTextBoxColumn.Name = "kvmDataGridViewTextBoxColumn";
            // 
            // salgsPrisDataGridViewTextBoxColumn
            // 
            this.salgsPrisDataGridViewTextBoxColumn.DataPropertyName = "salgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.HeaderText = "salgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salgsPrisDataGridViewTextBoxColumn.Name = "salgsPrisDataGridViewTextBoxColumn";
            // 
            // handelsPrisDataGridViewTextBoxColumn
            // 
            this.handelsPrisDataGridViewTextBoxColumn.DataPropertyName = "handelsPris";
            this.handelsPrisDataGridViewTextBoxColumn.HeaderText = "handelsPris";
            this.handelsPrisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.handelsPrisDataGridViewTextBoxColumn.Name = "handelsPrisDataGridViewTextBoxColumn";
            // 
            // handelsDatoDataGridViewTextBoxColumn
            // 
            this.handelsDatoDataGridViewTextBoxColumn.DataPropertyName = "handelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.HeaderText = "handelsDato";
            this.handelsDatoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.handelsDatoDataGridViewTextBoxColumn.Name = "handelsDatoDataGridViewTextBoxColumn";
            // 
            // kIDDataGridViewTextBoxColumn
            // 
            this.kIDDataGridViewTextBoxColumn.DataPropertyName = "kID";
            this.kIDDataGridViewTextBoxColumn.HeaderText = "kID";
            this.kIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kIDDataGridViewTextBoxColumn.Name = "kIDDataGridViewTextBoxColumn";
            // 
            // eIDDataGridViewTextBoxColumn
            // 
            this.eIDDataGridViewTextBoxColumn.DataPropertyName = "eID";
            this.eIDDataGridViewTextBoxColumn.HeaderText = "eID";
            this.eIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eIDDataGridViewTextBoxColumn.Name = "eIDDataGridViewTextBoxColumn";
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            this.boligBindingSource.DataSource = this.tHEONETHEONLY;
            // 
            // tHEONETHEONLY
            // 
            this.tHEONETHEONLY.DataSetName = "THEONETHEONLY";
            this.tHEONETHEONLY.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.handelsdato);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.eID);
            this.panel1.Controls.Add(this.sID);
            this.panel1.Controls.Add(this.handelspris);
            this.panel1.Controls.Add(this.kvm);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.salgspris);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Controls.Add(this.soldCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 211);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 331);
            this.panel2.TabIndex = 2;
            // 
            // soldCheck
            // 
            this.soldCheck.AutoSize = true;
            this.soldCheck.Location = new System.Drawing.Point(572, 24);
            this.soldCheck.Name = "soldCheck";
            this.soldCheck.Size = new System.Drawing.Size(72, 24);
            this.soldCheck.TabIndex = 0;
            this.soldCheck.Text = "Solgt";
            this.soldCheck.UseVisualStyleBackColor = true;
            this.soldCheck.CheckedChanged += new System.EventHandler(this.soldCheck_CheckedChanged);
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.Location = new System.Drawing.Point(837, 27);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(158, 34);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Opret";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.Location = new System.Drawing.Point(837, 71);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(158, 34);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Opdater";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(837, 114);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(158, 34);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Slet";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(909, 167);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(86, 27);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // salgspris
            // 
            this.salgspris.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salgspris.Location = new System.Drawing.Point(399, 27);
            this.salgspris.Name = "salgspris";
            this.salgspris.Size = new System.Drawing.Size(134, 19);
            this.salgspris.TabIndex = 5;
            this.salgspris.TextChanged += new System.EventHandler(this.salgspris_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(88, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 19);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // kvm
            // 
            this.kvm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kvm.Location = new System.Drawing.Point(88, 121);
            this.kvm.Name = "kvm";
            this.kvm.Size = new System.Drawing.Size(134, 19);
            this.kvm.TabIndex = 7;
            this.kvm.TextChanged += new System.EventHandler(this.kvm_TextChanged);
            // 
            // handelspris
            // 
            this.handelspris.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.handelspris.Location = new System.Drawing.Point(669, 76);
            this.handelspris.Name = "handelspris";
            this.handelspris.Size = new System.Drawing.Size(134, 19);
            this.handelspris.TabIndex = 8;
            this.handelspris.TextChanged += new System.EventHandler(this.handelspris_TextChanged);
            // 
            // sID
            // 
            this.sID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sID.Location = new System.Drawing.Point(399, 71);
            this.sID.Name = "sID";
            this.sID.Size = new System.Drawing.Size(134, 19);
            this.sID.TabIndex = 9;
            this.sID.TextChanged += new System.EventHandler(this.sID_TextChanged);
            // 
            // eID
            // 
            this.eID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eID.Location = new System.Drawing.Point(399, 119);
            this.eID.Name = "eID";
            this.eID.Size = new System.Drawing.Size(134, 19);
            this.eID.TabIndex = 10;
            this.eID.TextChanged += new System.EventHandler(this.eID_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(88, 26);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(134, 19);
            this.textBox7.TabIndex = 11;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // handelsdato
            // 
            this.handelsdato.Location = new System.Drawing.Point(669, 124);
            this.handelsdato.Name = "handelsdato";
            this.handelsdato.Size = new System.Drawing.Size(134, 26);
            this.handelsdato.TabIndex = 12;
            this.handelsdato.ValueChanged += new System.EventHandler(this.handelsdato_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Postnr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kvm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Salgspris";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sælger ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ejendomsmægler ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Handelspris";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Handelsdato";
            // 
            // V2CRUDBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "V2CRUDBolig";
            this.Text = "V2CRUDBolig";
            this.Load += new System.EventHandler(this.V2CRUDBolig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEONETHEONLY)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private THEONETHEONLY tHEONETHEONLY;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private THEONETHEONLYTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solgtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handelsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handelsDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker handelsdato;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox eID;
        private System.Windows.Forms.TextBox sID;
        private System.Windows.Forms.TextBox handelspris;
        private System.Windows.Forms.TextBox kvm;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox salgspris;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.CheckBox soldCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}