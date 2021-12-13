
namespace Semesterprojektet
{
    partial class v3crudkunder
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
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tHEDATASETOFALL = new Semesterprojektet.tHEDATASETOFALL();
            this.kunderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kunderTableAdapter = new Semesterprojektet.tHEDATASETOFALLTableAdapters.KunderTableAdapter();
            this.kIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saelgerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.koeberDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saeglerCheck = new System.Windows.Forms.CheckBox();
            this.koeberCheck = new System.Windows.Forms.CheckBox();
            this.email = new System.Windows.Forms.TextBox();
            this.efternavn = new System.Windows.Forms.TextBox();
            this.fornavn = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kunderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.fornavn);
            this.panel1.Controls.Add(this.efternavn);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.koeberCheck);
            this.panel1.Controls.Add(this.saeglerCheck);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 612);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(258, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 612);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(540, 612);
            this.dataGridView1.TabIndex = 0;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(59, 274);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(137, 42);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Opret";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(59, 323);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(137, 42);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Opdater";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(59, 372);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(137, 37);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Slet";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fornavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Efternavn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kIDDataGridViewTextBoxColumn,
            this.fNavnDataGridViewTextBoxColumn,
            this.eNavnDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.saelgerDataGridViewCheckBoxColumn,
            this.koeberDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.kunderBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(540, 612);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sælger";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(136, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Køber";
            // 
            // saeglerCheck
            // 
            this.saeglerCheck.AutoSize = true;
            this.saeglerCheck.Location = new System.Drawing.Point(31, 220);
            this.saeglerCheck.Name = "saeglerCheck";
            this.saeglerCheck.Size = new System.Drawing.Size(22, 21);
            this.saeglerCheck.TabIndex = 9;
            this.saeglerCheck.UseVisualStyleBackColor = true;
            // 
            // koeberCheck
            // 
            this.koeberCheck.AutoSize = true;
            this.koeberCheck.Location = new System.Drawing.Point(140, 220);
            this.koeberCheck.Name = "koeberCheck";
            this.koeberCheck.Size = new System.Drawing.Size(22, 21);
            this.koeberCheck.TabIndex = 10;
            this.koeberCheck.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(130, 148);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 26);
            this.email.TabIndex = 11;
            // 
            // efternavn
            // 
            this.efternavn.Location = new System.Drawing.Point(130, 110);
            this.efternavn.Name = "efternavn";
            this.efternavn.Size = new System.Drawing.Size(100, 26);
            this.efternavn.TabIndex = 12;
            // 
            // fornavn
            // 
            this.fornavn.Location = new System.Drawing.Point(130, 71);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(100, 26);
            this.fornavn.TabIndex = 13;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(130, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 26);
            this.id.TabIndex = 14;
            // 
            // v3crudkunder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "v3crudkunder";
            this.Text = "v3crudkunder";
            this.Load += new System.EventHandler(this.v3crudkunder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDATASETOFALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kunderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private tHEDATASETOFALL tHEDATASETOFALL;
        private System.Windows.Forms.BindingSource kunderBindingSource;
        private tHEDATASETOFALLTableAdapters.KunderTableAdapter kunderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn saelgerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn koeberDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox fornavn;
        private System.Windows.Forms.TextBox efternavn;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.CheckBox koeberCheck;
        private System.Windows.Forms.CheckBox saeglerCheck;
    }
}