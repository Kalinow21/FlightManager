namespace FlightManager.View
{
    partial class LoginView
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
            this.FlighManagerlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FlighManagerlbl
            // 
            this.FlighManagerlbl.BackColor = System.Drawing.Color.Transparent;
            this.FlighManagerlbl.Font = new System.Drawing.Font("Segoe UI", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FlighManagerlbl.ForeColor = System.Drawing.Color.MediumBlue;
            this.FlighManagerlbl.Location = new System.Drawing.Point(324, -1);
            this.FlighManagerlbl.Name = "FlighManagerlbl";
            this.FlighManagerlbl.Size = new System.Drawing.Size(275, 96);
            this.FlighManagerlbl.TabIndex = 0;
            this.FlighManagerlbl.Text = "Fligh Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlightManager.Properties.Resources._123a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlighManagerlbl);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FlighManagerlbl;
        private Label label1;
    }
}