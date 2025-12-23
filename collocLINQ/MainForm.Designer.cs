namespace collocLINQ
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
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.txtBrandFilter = new System.Windows.Forms.TextBox();
            this.btnFilterByBrand = new System.Windows.Forms.Button();
            this.btnGroupByBodyType = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSortByPower = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(21, 35);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.Size = new System.Drawing.Size(345, 290);
            this.dataGridViewCars.TabIndex = 0;
            // 
            // txtBrandFilter
            // 
            this.txtBrandFilter.Location = new System.Drawing.Point(416, 35);
            this.txtBrandFilter.Name = "txtBrandFilter";
            this.txtBrandFilter.Size = new System.Drawing.Size(186, 20);
            this.txtBrandFilter.TabIndex = 1;
            // 
            // btnFilterByBrand
            // 
            this.btnFilterByBrand.Location = new System.Drawing.Point(416, 211);
            this.btnFilterByBrand.Name = "btnFilterByBrand";
            this.btnFilterByBrand.Size = new System.Drawing.Size(82, 50);
            this.btnFilterByBrand.TabIndex = 2;
            this.btnFilterByBrand.Text = "фильтр по марке";
            this.btnFilterByBrand.UseVisualStyleBackColor = true;
            this.btnFilterByBrand.Click += new System.EventHandler(this.btnFilterByBrand_Click);
            // 
            // btnGroupByBodyType
            // 
            this.btnGroupByBodyType.Location = new System.Drawing.Point(631, 211);
            this.btnGroupByBodyType.Name = "btnGroupByBodyType";
            this.btnGroupByBodyType.Size = new System.Drawing.Size(84, 50);
            this.btnGroupByBodyType.TabIndex = 3;
            this.btnGroupByBodyType.Text = "фильтр по кузову";
            this.btnGroupByBodyType.UseVisualStyleBackColor = true;
            this.btnGroupByBodyType.Click += new System.EventHandler(this.btnGroupByBodyType_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(416, 87);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 38);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(518, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSortByPower
            // 
            this.btnSortByPower.Location = new System.Drawing.Point(527, 212);
            this.btnSortByPower.Name = "btnSortByPower";
            this.btnSortByPower.Size = new System.Drawing.Size(75, 49);
            this.btnSortByPower.TabIndex = 7;
            this.btnSortByPower.Text = "фильтр по л.с.";
            this.btnSortByPower.UseVisualStyleBackColor = true;
            this.btnSortByPower.Click += new System.EventHandler(this.btnSortByPower_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(21, 377);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(345, 147);
            this.listBoxResults.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 598);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.btnSortByPower);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnGroupByBodyType);
            this.Controls.Add(this.btnFilterByBrand);
            this.Controls.Add(this.txtBrandFilter);
            this.Controls.Add(this.dataGridViewCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.TextBox txtBrandFilter;
        private System.Windows.Forms.Button btnFilterByBrand;
        private System.Windows.Forms.Button btnGroupByBodyType;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSortByPower;
        private System.Windows.Forms.ListBox listBoxResults;
    }
}

