namespace IchirakuRamenShop
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnBack = new Button();
            imageList1 = new ImageList(components);
            label2 = new Label();
            label5 = new Label();
            txtPhone = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 159);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1265390;
            pictureBox1.Location = new Point(171, 9);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(9, 126);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 28);
            label1.TabIndex = 0;
            label1.Text = "Please Enter Your Information";
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 216);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(360, 31);
            txtName.TabIndex = 2;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 262);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(80, 297);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(360, 31);
            txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 351);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(80, 390);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(360, 31);
            txtPassword.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Orange;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(58, 559);
            btnRegister.Margin = new Padding(2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 48);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Orange;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(268, 559);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 48);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 180);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 440);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 11;
            label5.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(80, 467);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(360, 31);
            txtPhone.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 672);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sx";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtName;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnBack;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label5;
        private TextBox txtPhone;
    }
}