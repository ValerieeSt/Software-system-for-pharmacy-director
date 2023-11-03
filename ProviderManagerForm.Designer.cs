namespace PharmacyApp
{
    partial class ProviderManagerForm
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.ProviderAddButton = new System.Windows.Forms.Button();
            this.ProvidertName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProviderDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductQuantity = new System.Windows.Forms.TextBox();
            this.ProductListDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProviderProductDataGrid = new System.Windows.Forms.DataGridView();
            this.gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderDataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderProductDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.ProviderAddButton);
            this.gb.Controls.Add(this.ProvidertName);
            this.gb.Controls.Add(this.label1);
            this.gb.Location = new System.Drawing.Point(12, 444);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(412, 107);
            this.gb.TabIndex = 6;
            this.gb.TabStop = false;
            this.gb.Text = "Добавление поставщика";
            // 
            // ProviderAddButton
            // 
            this.ProviderAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProviderAddButton.Location = new System.Drawing.Point(10, 70);
            this.ProviderAddButton.Name = "ProviderAddButton";
            this.ProviderAddButton.Size = new System.Drawing.Size(391, 23);
            this.ProviderAddButton.TabIndex = 2;
            this.ProviderAddButton.Text = "Добавить";
            this.ProviderAddButton.UseVisualStyleBackColor = true;
            this.ProviderAddButton.Click += new System.EventHandler(this.ProviderAddButton_Click);
            // 
            // ProvidertName
            // 
            this.ProvidertName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProvidertName.Location = new System.Drawing.Point(10, 37);
            this.ProvidertName.Name = "ProvidertName";
            this.ProvidertName.Size = new System.Drawing.Size(391, 20);
            this.ProvidertName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название поставщика";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProviderDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 426);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поставщики";
            // 
            // ProviderDataGrid
            // 
            this.ProviderDataGrid.AllowUserToAddRows = false;
            this.ProviderDataGrid.AllowUserToDeleteRows = false;
            this.ProviderDataGrid.AllowUserToResizeColumns = false;
            this.ProviderDataGrid.AllowUserToResizeRows = false;
            this.ProviderDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProviderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProviderDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProviderDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProviderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProviderDataGrid.Location = new System.Drawing.Point(6, 19);
            this.ProviderDataGrid.Name = "ProviderDataGrid";
            this.ProviderDataGrid.ReadOnly = true;
            this.ProviderDataGrid.RowHeadersVisible = false;
            this.ProviderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProviderDataGrid.ShowCellErrors = false;
            this.ProviderDataGrid.ShowEditingIcon = false;
            this.ProviderDataGrid.ShowRowErrors = false;
            this.ProviderDataGrid.Size = new System.Drawing.Size(400, 401);
            this.ProviderDataGrid.TabIndex = 1;
            this.ProviderDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProviderDataGrid_CellClick);
            this.ProviderDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProviderDataGrid_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ProductQuantity);
            this.groupBox2.Controls.Add(this.ProductListDataGrid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.AddProductButton);
            this.groupBox2.Controls.Add(this.ProductPrice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(430, 458);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 329);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление товара поставщику";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество";
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductQuantity.Location = new System.Drawing.Point(10, 246);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(361, 20);
            this.ProductQuantity.TabIndex = 4;
            // 
            // ProductListDataGrid
            // 
            this.ProductListDataGrid.AllowUserToAddRows = false;
            this.ProductListDataGrid.AllowUserToDeleteRows = false;
            this.ProductListDataGrid.AllowUserToResizeColumns = false;
            this.ProductListDataGrid.AllowUserToResizeRows = false;
            this.ProductListDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductListDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductListDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProductListDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductListDataGrid.Location = new System.Drawing.Point(10, 47);
            this.ProductListDataGrid.Name = "ProductListDataGrid";
            this.ProductListDataGrid.ReadOnly = true;
            this.ProductListDataGrid.RowHeadersVisible = false;
            this.ProductListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductListDataGrid.ShowCellErrors = false;
            this.ProductListDataGrid.ShowEditingIcon = false;
            this.ProductListDataGrid.ShowRowErrors = false;
            this.ProductListDataGrid.Size = new System.Drawing.Size(361, 135);
            this.ProductListDataGrid.TabIndex = 2;
            this.ProductListDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductListDataGrid_CellClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цена";
            // 
            // AddProductButton
            // 
            this.AddProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductButton.Location = new System.Drawing.Point(10, 292);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(361, 23);
            this.AddProductButton.TabIndex = 2;
            this.AddProductButton.Text = "Добавить";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductPrice
            // 
            this.ProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPrice.Location = new System.Drawing.Point(10, 201);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(361, 20);
            this.ProductPrice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Товар";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProviderProductDataGrid);
            this.groupBox3.Location = new System.Drawing.Point(430, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 426);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Товары поставщика";
            // 
            // ProviderProductDataGrid
            // 
            this.ProviderProductDataGrid.AllowUserToAddRows = false;
            this.ProviderProductDataGrid.AllowUserToDeleteRows = false;
            this.ProviderProductDataGrid.AllowUserToResizeColumns = false;
            this.ProviderProductDataGrid.AllowUserToResizeRows = false;
            this.ProviderProductDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProviderProductDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProviderProductDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProviderProductDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProviderProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProviderProductDataGrid.Location = new System.Drawing.Point(6, 19);
            this.ProviderProductDataGrid.Name = "ProviderProductDataGrid";
            this.ProviderProductDataGrid.ReadOnly = true;
            this.ProviderProductDataGrid.RowHeadersVisible = false;
            this.ProviderProductDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProviderProductDataGrid.ShowCellErrors = false;
            this.ProviderProductDataGrid.ShowEditingIcon = false;
            this.ProviderProductDataGrid.ShowRowErrors = false;
            this.ProviderProductDataGrid.Size = new System.Drawing.Size(370, 401);
            this.ProviderProductDataGrid.TabIndex = 1;
            this.ProviderProductDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProviderProductDataGrid_CellClick);
            // 
            // ProviderManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 799);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProviderManagerForm";
            this.Text = "ProviderManager";
            this.Load += new System.EventHandler(this.ProviderManagerForm_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProviderDataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProviderProductDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button ProviderAddButton;
        private System.Windows.Forms.TextBox ProvidertName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ProviderDataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ProviderProductDataGrid;
        private System.Windows.Forms.DataGridView ProductListDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductQuantity;
    }
}