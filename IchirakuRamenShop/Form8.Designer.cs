namespace IchirakuRamenShop
{
    partial class Form8
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gridOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridOrder).BeginInit();
            SuspendLayout();
            // 
            // gridOrder
            // 
            gridOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridOrder.DefaultCellStyle = dataGridViewCellStyle1;
            gridOrder.Location = new Point(0, 31);
            gridOrder.Margin = new Padding(4, 4, 4, 4);
            gridOrder.Name = "gridOrder";
            gridOrder.RowHeadersWidth = 62;
            gridOrder.Size = new Size(1027, 473);
            gridOrder.TabIndex = 0;
            gridOrder.CellContentClick += gridOrder_CellContentClick;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(gridOrder);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)gridOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridOrder;
    }
}