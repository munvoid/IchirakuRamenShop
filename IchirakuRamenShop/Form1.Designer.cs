namespace IchirakuRamenShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            textUsername = new TextBox();
            label2 = new Label();
            textPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            lblStatus = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(guna2ControlBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 345);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(568, 12);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox1.Size = new Size(90, 58);
            guna2ControlBox1.TabIndex = 8;
            guna2ControlBox1.Click += guna2ControlBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.user_1281;
            pictureBox1.Location = new Point(216, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 296);
            label3.Name = "label3";
            label3.Size = new Size(400, 37);
            label3.TabIndex = 7;
            label3.Text = "Please Enter User Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 399);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(115, 460);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(421, 43);
            textUsername.TabIndex = 2;
            textUsername.TextChanged += textUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 530);
            label2.Name = "label2";
            label2.Size = new Size(128, 37);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(115, 595);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(421, 43);
            textPassword.TabIndex = 4;
            textPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Orange;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(115, 758);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 60);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Orange;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(366, 758);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(170, 60);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button2_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(85, 664);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(494, 57);
            lblStatus.TabIndex = 7;
            lblStatus.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 860);
            Controls.Add(lblStatus);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(textPassword);
            Controls.Add(label2);
            Controls.Add(textUsername);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textUsername;
        private Label label2;
        private TextBox textPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lblStatus;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}
