namespace FirstForm
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.NormalCalc = new System.Windows.Forms.Button();
            this.IngCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NormalCalc
            // 
            this.NormalCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NormalCalc.Location = new System.Drawing.Point(12, 132);
            this.NormalCalc.Name = "NormalCalc";
            this.NormalCalc.Size = new System.Drawing.Size(200, 23);
            this.NormalCalc.TabIndex = 0;
            this.NormalCalc.Text = "Стандартный калькулятор";
            this.toolTip1.SetToolTip(this.NormalCalc, "Операции сложения, вычитания, \r\nумножения и деления");
            this.NormalCalc.UseVisualStyleBackColor = true;
            this.NormalCalc.Click += new System.EventHandler(this.NormalCalc_Click);
            // 
            // IngCalc
            // 
            this.IngCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IngCalc.Location = new System.Drawing.Point(218, 132);
            this.IngCalc.Name = "IngCalc";
            this.IngCalc.Size = new System.Drawing.Size(186, 23);
            this.IngCalc.TabIndex = 1;
            this.IngCalc.Text = "Инженерный калькулятор";
            this.toolTip1.SetToolTip(this.IngCalc, "Число в степень,квадратный корень,\r\n обратное значение, квадрат");
            this.IngCalc.UseVisualStyleBackColor = true;
            this.IngCalc.Click += new System.EventHandler(this.IngCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(11, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите, какой калькулятор использовать:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(127, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Здравствуйте!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фонToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фонToolStripMenuItem
            // 
            this.фонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.светлыйToolStripMenuItem,
            this.темныйToolStripMenuItem,
            this.стандартныйToolStripMenuItem});
            this.фонToolStripMenuItem.Name = "фонToolStripMenuItem";
            this.фонToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.фонToolStripMenuItem.Text = "Фон";
            // 
            // светлыйToolStripMenuItem
            // 
            this.светлыйToolStripMenuItem.Name = "светлыйToolStripMenuItem";
            this.светлыйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.светлыйToolStripMenuItem.Text = "Светлый";
            this.светлыйToolStripMenuItem.Click += new System.EventHandler(this.светлыйToolStripMenuItem_Click);
            // 
            // темныйToolStripMenuItem
            // 
            this.темныйToolStripMenuItem.Name = "темныйToolStripMenuItem";
            this.темныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.темныйToolStripMenuItem.Text = "Темный";
            this.темныйToolStripMenuItem.Click += new System.EventHandler(this.темныйToolStripMenuItem_Click);
            // 
            // стандартныйToolStripMenuItem
            // 
            this.стандартныйToolStripMenuItem.Name = "стандартныйToolStripMenuItem";
            this.стандартныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.стандартныйToolStripMenuItem.Text = "Стандартный";
            this.стандартныйToolStripMenuItem.Click += new System.EventHandler(this.стандартныйToolStripMenuItem_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(416, 210);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngCalc);
            this.Controls.Add(this.NormalCalc);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator by Vlad";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NormalCalc;
        private System.Windows.Forms.Button IngCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светлыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартныйToolStripMenuItem;
    }
}

