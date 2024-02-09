namespace LoginScreen.Controls
{
    partial class Icomes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(312, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Page 4";
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.Location = new System.Drawing.Point(275, 192);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.Size = new System.Drawing.Size(216, 57);
            this.guna2RatingStar1.TabIndex = 6;
            // 
            // Icomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2RatingStar1);
            this.Name = "Icomes";
            this.Size = new System.Drawing.Size(931, 417);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
    }
}
