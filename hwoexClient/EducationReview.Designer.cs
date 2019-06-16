namespace hwoexClient
{
    partial class EducationReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationReview));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1C = new System.Windows.Forms.TextBox();
            this.textBox2C = new System.Windows.Forms.TextBox();
            this.textBox3C = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox4C = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.TabIndex = 71;
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
            this.button1.TabIndex = 124;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1C
            // 
            this.textBox1C.Location = new System.Drawing.Point(145, 33);
            this.textBox1C.Name = "textBox1C";
            this.textBox1C.Size = new System.Drawing.Size(143, 20);
            this.textBox1C.TabIndex = 137;
            // 
            // textBox2C
            // 
            this.textBox2C.ForeColor = System.Drawing.Color.Black;
            this.textBox2C.Location = new System.Drawing.Point(145, 131);
            this.textBox2C.Name = "textBox2C";
            this.textBox2C.Size = new System.Drawing.Size(143, 20);
            this.textBox2C.TabIndex = 136;
            // 
            // textBox3C
            // 
            this.textBox3C.ForeColor = System.Drawing.Color.Black;
            this.textBox3C.Location = new System.Drawing.Point(520, 36);
            this.textBox3C.Name = "textBox3C";
            this.textBox3C.Size = new System.Drawing.Size(143, 20);
            this.textBox3C.TabIndex = 135;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(399, 134);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 131;
            this.label23.Text = "Факультет:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(399, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 13);
            this.label27.TabIndex = 127;
            this.label27.Text = "Тип:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(32, 134);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 13);
            this.label28.TabIndex = 126;
            this.label28.Text = "Акридетація:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(32, 33);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 13);
            this.label29.TabIndex = 125;
            this.label29.Text = "Назва:";
            // 
            // textBox4C
            // 
            this.textBox4C.ForeColor = System.Drawing.Color.Black;
            this.textBox4C.Location = new System.Drawing.Point(520, 131);
            this.textBox4C.Name = "textBox4C";
            this.textBox4C.Size = new System.Drawing.Size(143, 20);
            this.textBox4C.TabIndex = 134;
            // 
            // EducationReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1C);
            this.Controls.Add(this.textBox2C);
            this.Controls.Add(this.textBox3C);
            this.Controls.Add(this.textBox4C);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EducationReview";
            this.Size = new System.Drawing.Size(762, 477);
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
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox4C;
    }
}
