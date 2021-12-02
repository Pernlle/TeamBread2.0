
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
            this.BoligBtn = new System.Windows.Forms.Button();
            this.SaeglerBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoligBtn
            // 
            this.BoligBtn.Location = new System.Drawing.Point(144, 155);
            this.BoligBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BoligBtn.Name = "BoligBtn";
            this.BoligBtn.Size = new System.Drawing.Size(133, 87);
            this.BoligBtn.TabIndex = 0;
            this.BoligBtn.Text = "Bolig";
            this.BoligBtn.UseVisualStyleBackColor = true;
            this.BoligBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaeglerBtn
            // 
            this.SaeglerBtn.Location = new System.Drawing.Point(415, 155);
            this.SaeglerBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaeglerBtn.Name = "SaeglerBtn";
            this.SaeglerBtn.Size = new System.Drawing.Size(133, 87);
            this.SaeglerBtn.TabIndex = 1;
            this.SaeglerBtn.Text = "Sælger";
            this.SaeglerBtn.UseVisualStyleBackColor = true;
            this.SaeglerBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaeglerBtn);
            this.panel1.Controls.Add(this.BoligBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 454);
            this.panel1.TabIndex = 2;
            // 
            // EMPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 454);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EMPanel";
            this.Text = "EMPanel";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaeglerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BoligBtn;
    }
}