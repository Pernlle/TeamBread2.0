
namespace Semesterprojektet
{
    partial class EMPanel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boligbtn = new System.Windows.Forms.Button();
            this.saelgerbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Semesterprojektet.Properties.Resources.Billede1__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // boligbtn
            // 
            this.boligbtn.BackColor = System.Drawing.Color.Silver;
            this.boligbtn.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boligbtn.Location = new System.Drawing.Point(84, 96);
            this.boligbtn.Name = "boligbtn";
            this.boligbtn.Size = new System.Drawing.Size(293, 70);
            this.boligbtn.TabIndex = 1;
            this.boligbtn.Text = "BOLIG";
            this.boligbtn.UseVisualStyleBackColor = false;
            this.boligbtn.Click += new System.EventHandler(this.boligbtn_Click);
            // 
            // saelgerbtn
            // 
            this.saelgerbtn.BackColor = System.Drawing.Color.Silver;
            this.saelgerbtn.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saelgerbtn.Location = new System.Drawing.Point(84, 217);
            this.saelgerbtn.Name = "saelgerbtn";
            this.saelgerbtn.Size = new System.Drawing.Size(293, 70);
            this.saelgerbtn.TabIndex = 2;
            this.saelgerbtn.Text = "SÆLGER";
            this.saelgerbtn.UseVisualStyleBackColor = false;
            this.saelgerbtn.Click += new System.EventHandler(this.saelgerbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 403);
            this.panel1.TabIndex = 3;
            // 
            // EMPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(659, 403);
            this.Controls.Add(this.saelgerbtn);
            this.Controls.Add(this.boligbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EMPanel";
            this.Text = "EMPanel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boligbtn;
        private System.Windows.Forms.Button saelgerbtn;
        private System.Windows.Forms.Panel panel1;
    }
}