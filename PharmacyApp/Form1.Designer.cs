namespace PharmacyApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PharmacyDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Добавить = new System.Windows.Forms.GroupBox();
            this.PharmacyAddButton = new System.Windows.Forms.Button();
            this.PharmacyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PharmacyProductDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PharmacyProviderDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ProviderProductDataGrid = new System.Windows.Forms.DataGridView();
            this.DeletePharmacyProductButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Preference = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProviderListDataGrid = new System.Windows.Forms.DataGridView();
            this.AddProviderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProductToPharmacyButton = new System.Windows.Forms.Button();
            this.dataStorageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Добавить.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyProductDataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyProviderDataGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderProductDataGrid)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStorageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PharmacyDataGrid
            // 
            this.PharmacyDataGrid.AllowUserToAddRows = false;
            this.PharmacyDataGrid.AllowUserToDeleteRows = false;
            this.PharmacyDataGrid.AllowUserToResizeColumns = false;
            this.PharmacyDataGrid.AllowUserToResizeRows = false;
            this.PharmacyDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PharmacyDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PharmacyDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.PharmacyDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PharmacyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PharmacyDataGrid.Location = new System.Drawing.Point(6, 19);
            this.PharmacyDataGrid.Name = "PharmacyDataGrid";
            this.PharmacyDataGrid.ReadOnly = true;
            this.PharmacyDataGrid.RowHeadersVisible = false;
            this.PharmacyDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PharmacyDataGrid.ShowCellErrors = false;
            this.PharmacyDataGrid.ShowEditingIcon = false;
            this.PharmacyDataGrid.ShowRowErrors = false;
            this.PharmacyDataGrid.Size = new System.Drawing.Size(514, 137);
            this.PharmacyDataGrid.TabIndex = 1;
            this.PharmacyDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PharmacyDataGrid_CellClick);
            this.PharmacyDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PharmacyDataGrid_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PharmacyDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Аптеки";
            // 
            // Добавить
            // 
            this.Добавить.Controls.Add(this.PharmacyAddButton);
            this.Добавить.Controls.Add(this.PharmacyName);
            this.Добавить.Controls.Add(this.label1);
            this.Добавить.Location = new System.Drawing.Point(12, 180);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(526, 99);
            this.Добавить.TabIndex = 2;
            this.Добавить.TabStop = false;
            this.Добавить.Text = "Добавление аптеки";
            // 
            // PharmacyAddButton
            // 
            this.PharmacyAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PharmacyAddButton.Location = new System.Drawing.Point(10, 64);
            this.PharmacyAddButton.Name = "PharmacyAddButton";
            this.PharmacyAddButton.Size = new System.Drawing.Size(505, 21);
            this.PharmacyAddButton.TabIndex = 2;
            this.PharmacyAddButton.Text = "Добавить";
            this.PharmacyAddButton.UseVisualStyleBackColor = true;
            this.PharmacyAddButton.Click += new System.EventHandler(this.PharmacyAddButton_Click);
            // 
            // PharmacyName
            // 
            this.PharmacyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PharmacyName.Location = new System.Drawing.Point(10, 37);
            this.PharmacyName.Name = "PharmacyName";
            this.PharmacyName.Size = new System.Drawing.Size(505, 20);
            this.PharmacyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименвоание аптеки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.PharmacyProductDataGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 316);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Товары в выбранной аптеке";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(370, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Списать просроченные товары";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(370, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Показать просроченные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Показать все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PharmacyProductDataGrid
            // 
            this.PharmacyProductDataGrid.AllowUserToAddRows = false;
            this.PharmacyProductDataGrid.AllowUserToDeleteRows = false;
            this.PharmacyProductDataGrid.AllowUserToResizeColumns = false;
            this.PharmacyProductDataGrid.AllowUserToResizeRows = false;
            this.PharmacyProductDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PharmacyProductDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PharmacyProductDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.PharmacyProductDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PharmacyProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PharmacyProductDataGrid.Location = new System.Drawing.Point(6, 136);
            this.PharmacyProductDataGrid.Name = "PharmacyProductDataGrid";
            this.PharmacyProductDataGrid.ReadOnly = true;
            this.PharmacyProductDataGrid.RowHeadersVisible = false;
            this.PharmacyProductDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PharmacyProductDataGrid.ShowCellErrors = false;
            this.PharmacyProductDataGrid.ShowEditingIcon = false;
            this.PharmacyProductDataGrid.ShowRowErrors = false;
            this.PharmacyProductDataGrid.Size = new System.Drawing.Size(514, 174);
            this.PharmacyProductDataGrid.TabIndex = 1;
            this.PharmacyProductDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PharmacyProductDataGrid_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PharmacyProviderDataGrid);
            this.groupBox3.Location = new System.Drawing.Point(538, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 168);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поставщики";
            // 
            // PharmacyProviderDataGrid
            // 
            this.PharmacyProviderDataGrid.AllowUserToAddRows = false;
            this.PharmacyProviderDataGrid.AllowUserToDeleteRows = false;
            this.PharmacyProviderDataGrid.AllowUserToResizeColumns = false;
            this.PharmacyProviderDataGrid.AllowUserToResizeRows = false;
            this.PharmacyProviderDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PharmacyProviderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PharmacyProviderDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.PharmacyProviderDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PharmacyProviderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PharmacyProviderDataGrid.Location = new System.Drawing.Point(6, 19);
            this.PharmacyProviderDataGrid.Name = "PharmacyProviderDataGrid";
            this.PharmacyProviderDataGrid.ReadOnly = true;
            this.PharmacyProviderDataGrid.RowHeadersVisible = false;
            this.PharmacyProviderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PharmacyProviderDataGrid.ShowCellErrors = false;
            this.PharmacyProviderDataGrid.ShowEditingIcon = false;
            this.PharmacyProviderDataGrid.ShowRowErrors = false;
            this.PharmacyProviderDataGrid.Size = new System.Drawing.Size(348, 143);
            this.PharmacyProviderDataGrid.TabIndex = 1;
            this.PharmacyProviderDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PharmacyProviderDataGrid_CellClick);
            this.PharmacyProviderDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PharmacyProviderDataGrid_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ProviderProductDataGrid);
            this.groupBox4.Location = new System.Drawing.Point(538, 452);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 149);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Товары у поставщиков";
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
            this.ProviderProductDataGrid.Size = new System.Drawing.Size(347, 124);
            this.ProviderProductDataGrid.TabIndex = 1;
            this.ProviderProductDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProviderProductDataGrid_CellClick);
            // 
            // DeletePharmacyProductButton
            // 
            this.DeletePharmacyProductButton.Enabled = false;
            this.DeletePharmacyProductButton.Location = new System.Drawing.Point(12, 607);
            this.DeletePharmacyProductButton.Name = "DeletePharmacyProductButton";
            this.DeletePharmacyProductButton.Size = new System.Drawing.Size(526, 23);
            this.DeletePharmacyProductButton.TabIndex = 6;
            this.DeletePharmacyProductButton.Text = "Удалить выбранный товар";
            this.DeletePharmacyProductButton.UseVisualStyleBackColor = true;
            this.DeletePharmacyProductButton.Click += new System.EventHandler(this.DeletePharmacyProductButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Preference);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.ProviderListDataGrid);
            this.groupBox5.Controls.Add(this.AddProviderButton);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(538, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(359, 266);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Добавление поставщика в аптеку";
            // 
            // Preference
            // 
            this.Preference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preference.Location = new System.Drawing.Point(10, 206);
            this.Preference.Name = "Preference";
            this.Preference.Size = new System.Drawing.Size(338, 20);
            this.Preference.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Предпочтение";
            // 
            // ProviderListDataGrid
            // 
            this.ProviderListDataGrid.AllowUserToAddRows = false;
            this.ProviderListDataGrid.AllowUserToDeleteRows = false;
            this.ProviderListDataGrid.AllowUserToResizeColumns = false;
            this.ProviderListDataGrid.AllowUserToResizeRows = false;
            this.ProviderListDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProviderListDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProviderListDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProviderListDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProviderListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProviderListDataGrid.Location = new System.Drawing.Point(6, 36);
            this.ProviderListDataGrid.Name = "ProviderListDataGrid";
            this.ProviderListDataGrid.ReadOnly = true;
            this.ProviderListDataGrid.RowHeadersVisible = false;
            this.ProviderListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProviderListDataGrid.ShowCellErrors = false;
            this.ProviderListDataGrid.ShowEditingIcon = false;
            this.ProviderListDataGrid.ShowRowErrors = false;
            this.ProviderListDataGrid.Size = new System.Drawing.Size(347, 148);
            this.ProviderListDataGrid.TabIndex = 2;
            this.ProviderListDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProviderListDataGrid_CellClick);
            // 
            // AddProviderButton
            // 
            this.AddProviderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProviderButton.Location = new System.Drawing.Point(10, 229);
            this.AddProviderButton.Name = "AddProviderButton";
            this.AddProviderButton.Size = new System.Drawing.Size(338, 23);
            this.AddProviderButton.TabIndex = 2;
            this.AddProviderButton.Text = "Добавить";
            this.AddProviderButton.UseVisualStyleBackColor = true;
            this.AddProviderButton.Click += new System.EventHandler(this.AddProviderButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Поставщик";
            // 
            // AddProductToPharmacyButton
            // 
            this.AddProductToPharmacyButton.Enabled = false;
            this.AddProductToPharmacyButton.Location = new System.Drawing.Point(538, 607);
            this.AddProductToPharmacyButton.Name = "AddProductToPharmacyButton";
            this.AddProductToPharmacyButton.Size = new System.Drawing.Size(359, 23);
            this.AddProductToPharmacyButton.TabIndex = 9;
            this.AddProductToPharmacyButton.Text = "Добавить товар в аптеку";
            this.AddProductToPharmacyButton.UseVisualStyleBackColor = true;
            this.AddProductToPharmacyButton.Click += new System.EventHandler(this.AddProductToPharmacyButton_Click);
            // 
            // dataStorageBindingSource
            // 
            this.dataStorageBindingSource.DataSource = typeof(PharmacyApp.DataStorage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 671);
            this.Controls.Add(this.AddProductToPharmacyButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.DeletePharmacyProductButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Добавить.ResumeLayout(false);
            this.Добавить.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyProductDataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyProviderDataGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProviderProductDataGrid)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStorageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataStorageBindingSource;
        private System.Windows.Forms.DataGridView PharmacyDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Добавить;
        private System.Windows.Forms.TextBox PharmacyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PharmacyAddButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView PharmacyProductDataGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView PharmacyProviderDataGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView ProviderProductDataGrid;
        private System.Windows.Forms.Button DeletePharmacyProductButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView ProviderListDataGrid;
        private System.Windows.Forms.Button AddProviderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProductToPharmacyButton;
        private System.Windows.Forms.TextBox Preference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

