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
            gridOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridOrder).BeginInit();
            SuspendLayout();
            // 
            // gridOrder
            // 
            gridOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrder.Location = new Point(0, 24);
            gridOrder.Name = "gridOrder";
            gridOrder.RowHeadersWidth = 62;
            gridOrder.Size = new Size(635, 201);
            gridOrder.TabIndex = 0;
            gridOrder.CellContentClick += gridOrder_CellContentClick;
            gridOrder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gridOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridOrder);
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