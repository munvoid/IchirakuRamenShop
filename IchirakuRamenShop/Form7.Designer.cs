namespace IchirakuRamenShop
{
    partial class Form7
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            label1 = new Label();
            panel2 = new Panel();
            btnSelectImg = new Guna.UI2.WinForms.Guna2Button();
            btnconfirm = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            label4 = new Label();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            label3 = new Label();
            txtPName = new TextBox();
            label2 = new Label();
            openFileDialog = new OpenFileDialog();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(guna2ControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 115);
            panel1.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(939, 28);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(90, 58);
            guna2ControlBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(294, 37);
            label1.TabIndex = 0;
            label1.Text = "Enter the information";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(guna2Button1);
            panel2.Controls.Add(btnSelectImg);
            panel2.Controls.Add(btnconfirm);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtDescription);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPName);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(1052, 629);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnSelectImg
            // 
            btnSelectImg.CustomizableEdges = customizableEdges5;
            btnSelectImg.DisabledState.BorderColor = Color.DarkGray;
            btnSelectImg.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSelectImg.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSelectImg.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSelectImg.FillColor = Color.White;
            btnSelectImg.Font = new Font("Segoe UI", 9F);
            btnSelectImg.ForeColor = Color.Black;
            btnSelectImg.Location = new Point(278, 453);
            btnSelectImg.Name = "btnSelectImg";
            btnSelectImg.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSelectImg.Size = new Size(382, 42);
            btnSelectImg.TabIndex = 10;
            btnSelectImg.Text = "Select image";
            btnSelectImg.Click += guna2Button2_Click;
            // 
            // btnconfirm
            // 
            btnconfirm.AutoRoundedCorners = true;
            btnconfirm.CustomizableEdges = customizableEdges7;
            btnconfirm.DisabledState.BorderColor = Color.DarkGray;
            btnconfirm.DisabledState.CustomBorderColor = Color.DarkGray;
            btnconfirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnconfirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnconfirm.Font = new Font("Segoe UI", 9F);
            btnconfirm.ForeColor = Color.White;
            btnconfirm.Location = new Point(296, 537);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnconfirm.Size = new Size(178, 69);
            btnconfirm.TabIndex = 9;
            btnconfirm.Text = "Confirm";
            btnconfirm.Click += btnconfirm_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 418);
            label5.Name = "label5";
            label5.Size = new Size(130, 32);
            label5.TabIndex = 7;
            label5.Text = "Image Link";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 293);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 6;
            label4.Text = "Description";
            label4.Click += label4_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(278, 351);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(382, 39);
            txtDescription.TabIndex = 5;
            txtDescription.TextChanged += textBox3_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(278, 215);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(382, 39);
            txtPrice.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 161);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 3;
            label3.Text = "Price";
            label3.Click += label3_Click;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(278, 82);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(382, 39);
            txtPName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 28);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            label2.Click += label2_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // guna2Button1
            // 
            guna2Button1.AutoRoundedCorners = true;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(480, 539);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(178, 69);
            guna2Button1.TabIndex = 11;
            guna2Button1.Text = "Back";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 744);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPName;
        private Label label4;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button btnconfirm;
        private Guna.UI2.WinForms.Guna2Button btnSelectImg;
        private OpenFileDialog openFileDialog;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}