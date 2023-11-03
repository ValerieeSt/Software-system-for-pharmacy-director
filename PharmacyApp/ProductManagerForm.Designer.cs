namespace PharmacyApp
{
    partial class ProductManagerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductDataGrid = new System.Windows.Forms.DataGridView();
            this.gb = new System.Windows.Forms.GroupBox();
            this.ProductPacking = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PharmacyAddButton = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).BeginInit();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(468, 524);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товары";
            // 
            // ProductDataGrid
            // 
            this.ProductDataGrid.AllowUserToAddRows = false;
            this.ProductDataGrid.AllowUserToDeleteRows = false;
            this.ProductDataGrid.AllowUserToResizeColumns = false;
            this.ProductDataGrid.AllowUserToResizeRows = false;
            this.ProductDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProductDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDataGrid.ColumnHeadersHeight = 29;
            this.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductDataGrid.Location = new System.Drawing.Point(8, 30);
            this.ProductDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductDataGrid.Name = "ProductDataGrid";
            this.ProductDataGrid.ReadOnly = true;
            this.ProductDataGrid.RowHeadersVisible = false;
            this.ProductDataGrid.RowHeadersWidth = 51;
            this.ProductDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGrid.ShowCellErrors = false;
            this.ProductDataGrid.ShowEditingIcon = false;
            this.ProductDataGrid.ShowRowErrors = false;
            this.ProductDataGrid.Size = new System.Drawing.Size(452, 494);
            this.ProductDataGrid.TabIndex = 1;
            this.ProductDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductDataGrid_CellFormatting);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.ProductPacking);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.PharmacyAddButton);
            this.gb.Controls.Add(this.ProductName);
            this.gb.Controls.Add(this.label1);
            this.gb.Location = new System.Drawing.Point(16, 546);
            this.gb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb.Name = "gb";
            this.gb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb.Size = new System.Drawing.Size(468, 180);
            this.gb.TabIndex = 4;
            this.gb.TabStop = false;
            this.gb.Text = "Добавление товара";
            // 
            // ProductPacking
            // 
            this.ProductPacking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPacking.Location = new System.Drawing.Point(13, 95);
            this.ProductPacking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductPacking.Name = "ProductPacking";
            this.ProductPacking.Size = new System.Drawing.Size(439, 22);
            this.ProductPacking.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фасовка";
            // 
            // PharmacyAddButton
            // 
            this.PharmacyAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PharmacyAddButton.Location = new System.Drawing.Point(13, 134);
            this.PharmacyAddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PharmacyAddButton.Name = "PharmacyAddButton";
            this.PharmacyAddButton.Size = new System.Drawing.Size(440, 28);
            this.PharmacyAddButton.TabIndex = 2;
            this.PharmacyAddButton.Text = "Добавить";
            this.PharmacyAddButton.UseVisualStyleBackColor = true;
            this.PharmacyAddButton.Click += new System.EventHandler(this.PharmacyAddButton_Click);
            // 
            // ProductName
            // 
            this.ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductName.Location = new System.Drawing.Point(13, 46);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(439, 22);
            this.ProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование товара";
            // 
            // ProductManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 741);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductManagerForm";
            this.Text = "ProductManagerForm";
            this.Load += new System.EventHandler(this.ProductManagerForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ProductDataGrid;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TextBox ProductPacking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PharmacyAddButton;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label1;
    }
}