namespace IchirakuRamenShop
{
    partial class ShowOrder
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
            gridOrder = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridOrder).BeginInit();
            SuspendLayout();
            // 
            // gridOrder
            // 
            gridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrder.Location = new Point(247, 114);
            gridOrder.Name = "gridOrder";
            gridOrder.RowHeadersWidth = 62;
            gridOrder.Size = new Size(360, 225);
            gridOrder.TabIndex = 0;
            gridOrder.CellContentClick += gridOrder_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 64);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // ShowOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(gridOrder);
            Name = "ShowOrder";
            Text = "ShowOrder";
            Load += Order_Loadx;
            ((System.ComponentModel.ISupportInitialize)gridOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridOrder;
        private Label label1;
    }
}