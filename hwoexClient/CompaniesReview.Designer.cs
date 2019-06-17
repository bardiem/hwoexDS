namespace hwoexClient
{
    partial class CompaniesReview
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompaniesReview));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1C = new System.Windows.Forms.TextBox();
            this.textBox2C = new System.Windows.Forms.TextBox();
            this.textBox3C = new System.Windows.Forms.TextBox();
            this.textBox4C = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(756, 175);
            this.dataGridView1.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(712, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 41);
            this.button1.TabIndex = 125;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1C
            // 
            this.textBox1C.Location = new System.Drawing.Point(146, 33);
            this.textBox1C.Name = "textBox1C";
            this.textBox1C.Size = new System.Drawing.Size(143, 20);
            this.textBox1C.TabIndex = 138;
            // 
            // textBox2C
            // 
            this.textBox2C.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2C.Location = new System.Drawing.Point(146, 141);
            this.textBox2C.Name = "textBox2C";
            this.textBox2C.Size = new System.Drawing.Size(143, 20);
            this.textBox2C.TabIndex = 137;
            // 
            // textBox3C
            // 
            this.textBox3C.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox3C.Location = new System.Drawing.Point(512, 27);
            this.textBox3C.Name = "textBox3C";
            this.textBox3C.Size = new System.Drawing.Size(143, 20);
            this.textBox3C.TabIndex = 136;
            // 
            // textBox4C
            // 
            this.textBox4C.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox4C.Location = new System.Drawing.Point(512, 141);
            this.textBox4C.Name = "textBox4C";
            this.textBox4C.Size = new System.Drawing.Size(143, 20);
            this.textBox4C.TabIndex = 135;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(399, 144);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 129;
            this.label26.Text = "Тип:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(33, 144);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 13);
            this.label28.TabIndex = 127;
            this.label28.Text = "Розмір:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(33, 33);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(88, 13);
            this.label29.TabIndex = 126;
            this.label29.Text = "Назва компанії:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(399, 27);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 13);
            this.label27.TabIndex = 128;
            this.label27.Text = "Директор:";
            // 
            // CompaniesReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1C);
            this.Controls.Add(this.textBox2C);
            this.Controls.Add(this.textBox3C);
            this.Controls.Add(this.textBox4C);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CompaniesReview";
            this.Size = new System.Drawing.Size(762, 477);
            this.Load += new System.EventHandler(this.CompaniesReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1C;
        private System.Windows.Forms.TextBox textBox2C;
        private System.Windows.Forms.TextBox textBox3C;
        private System.Windows.Forms.TextBox textBox4C;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
    }
}
