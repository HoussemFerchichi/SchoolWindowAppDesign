namespace LoginScreen.Controls
{
    partial class Home
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
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.Location = new System.Drawing.Point(350, 189);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.Size = new System.Drawing.Size(216, 57);
            this.guna2RatingStar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(408, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Page 1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2RatingStar1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(931, 417);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private System.Windows.Forms.Label label1;
    }
}
