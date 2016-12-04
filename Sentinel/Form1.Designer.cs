namespace Sentinel
{
    partial class Gen
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
            this.B_eva = new System.Windows.Forms.Button();
            this.TB_eva = new System.Windows.Forms.TextBox();
            this.CB_eva = new System.Windows.Forms.ComboBox();
            this.L_total = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.B_bonus = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.B_start = new System.Windows.Forms.Button();
            this.B_set = new System.Windows.Forms.Button();
            this.B_help = new System.Windows.Forms.Button();
            this.B_hist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_eva
            // 
            this.B_eva.Location = new System.Drawing.Point(258, 95);
            this.B_eva.Name = "B_eva";
            this.B_eva.Size = new System.Drawing.Size(40, 21);
            this.B_eva.TabIndex = 0;
            this.B_eva.Text = "OK";
            this.B_eva.UseVisualStyleBackColor = true;
            // 
            // TB_eva
            // 
            this.TB_eva.Location = new System.Drawing.Point(26, 95);
            this.TB_eva.Name = "TB_eva";
            this.TB_eva.Size = new System.Drawing.Size(22, 20);
            this.TB_eva.TabIndex = 1;
            // 
            // CB_eva
            // 
            this.CB_eva.FormattingEnabled = true;
            this.CB_eva.Location = new System.Drawing.Point(54, 94);
            this.CB_eva.Name = "CB_eva";
            this.CB_eva.Size = new System.Drawing.Size(180, 21);
            this.CB_eva.TabIndex = 2;
            // 
            // L_total
            // 
            this.L_total.AutoSize = true;
            this.L_total.Location = new System.Drawing.Point(134, 219);
            this.L_total.Name = "L_total";
            this.L_total.Size = new System.Drawing.Size(27, 13);
            this.L_total.TabIndex = 3;
            this.L_total.Text = "total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 6;
            // 
            // B_bonus
            // 
            this.B_bonus.Location = new System.Drawing.Point(258, 156);
            this.B_bonus.Name = "B_bonus";
            this.B_bonus.Size = new System.Drawing.Size(40, 23);
            this.B_bonus.TabIndex = 7;
            this.B_bonus.Text = "OK";
            this.B_bonus.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(30, 284);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(26, 13);
            this.timer.TabIndex = 8;
            this.timer.Text = "time";
            // 
            // B_start
            // 
            this.B_start.Location = new System.Drawing.Point(258, 267);
            this.B_start.Name = "B_start";
            this.B_start.Size = new System.Drawing.Size(40, 30);
            this.B_start.TabIndex = 9;
            this.B_start.Text = "Start";
            this.B_start.UseVisualStyleBackColor = true;
            // 
            // B_set
            // 
            this.B_set.Location = new System.Drawing.Point(12, 12);
            this.B_set.Name = "B_set";
            this.B_set.Size = new System.Drawing.Size(32, 23);
            this.B_set.TabIndex = 10;
            this.B_set.Text = "setup";
            this.B_set.UseVisualStyleBackColor = true;
            // 
            // B_help
            // 
            this.B_help.Location = new System.Drawing.Point(54, 13);
            this.B_help.Name = "B_help";
            this.B_help.Size = new System.Drawing.Size(29, 23);
            this.B_help.TabIndex = 11;
            this.B_help.Text = "help";
            this.B_help.UseVisualStyleBackColor = true;
            // 
            // B_hist
            // 
            this.B_hist.Location = new System.Drawing.Point(244, 13);
            this.B_hist.Name = "B_hist";
            this.B_hist.Size = new System.Drawing.Size(53, 23);
            this.B_hist.TabIndex = 12;
            this.B_hist.Text = "history";
            this.B_hist.UseVisualStyleBackColor = true;
            // 
            // Gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 309);
            this.Controls.Add(this.B_hist);
            this.Controls.Add(this.B_help);
            this.Controls.Add(this.B_set);
            this.Controls.Add(this.B_start);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.B_bonus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.L_total);
            this.Controls.Add(this.CB_eva);
            this.Controls.Add(this.TB_eva);
            this.Controls.Add(this.B_eva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Gen";
            this.Text = "Sentinel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_eva;
        private System.Windows.Forms.TextBox TB_eva;
        private System.Windows.Forms.ComboBox CB_eva;
        private System.Windows.Forms.Label L_total;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button B_bonus;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Button B_start;
        private System.Windows.Forms.Button B_set;
        private System.Windows.Forms.Button B_help;
        private System.Windows.Forms.Button B_hist;
    }
}

