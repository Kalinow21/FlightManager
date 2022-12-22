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
            this.components = new System.ComponentModel.Container();
            this.FlighManagerlbl = new System.Windows.Forms.Label();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Createlbl = new System.Windows.Forms.Label();
            this.Createbtn = new System.Windows.Forms.Button();
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
            // Usernamelbl
            // 
            this.Usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.Usernamelbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Usernamelbl.Location = new System.Drawing.Point(139, 105);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(120, 31);
            this.Usernamelbl.TabIndex = 1;
            this.Usernamelbl.Text = "Username";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.BackColor = System.Drawing.Color.Transparent;
            this.Passwordlbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Passwordlbl.Location = new System.Drawing.Point(139, 194);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(120, 31);
            this.Passwordlbl.TabIndex = 3;
            this.Passwordlbl.Text = "Password";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTextBox.Location = new System.Drawing.Point(143, 126);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(175, 42);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextbox.Location = new System.Drawing.Point(143, 216);
            this.PasswordTextbox.Multiline = true;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(175, 42);
            this.PasswordTextbox.TabIndex = 5;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.Location = new System.Drawing.Point(157, 301);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(144, 47);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            // 
            // Createlbl
            // 
            this.Createlbl.BackColor = System.Drawing.Color.Transparent;
            this.Createlbl.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Createlbl.Location = new System.Drawing.Point(667, 133);
            this.Createlbl.Name = "Createlbl";
            this.Createlbl.Size = new System.Drawing.Size(206, 35);
            this.Createlbl.TabIndex = 7;
            this.Createlbl.Text = "Create Account";
            // 
            // Createbtn
            // 
            this.Createbtn.BackColor = System.Drawing.Color.White;
            this.Createbtn.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Createbtn.Location = new System.Drawing.Point(695, 175);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(144, 42);
            this.Createbtn.TabIndex = 8;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = false;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlightManager.Properties.Resources._123a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 542);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.Createlbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.FlighManagerlbl);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FlighManagerlbl;
        private Label Usernamelbl;
        private ContextMenuStrip contextMenuStrip1;
        private Label Passwordlbl;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextbox;
        private Button LoginBtn;
        private Label Createlbl;
        private Button Createbtn;
    }
}