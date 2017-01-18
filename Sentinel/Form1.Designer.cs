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
            this.components = new System.ComponentModel.Container();
            this.B_Eva = new System.Windows.Forms.Button();
            this.TB_Eva = new System.Windows.Forms.TextBox();
            this.CB_Less = new System.Windows.Forms.ComboBox();
            this.L_Total = new System.Windows.Forms.Label();
            this.TB_Bonus = new System.Windows.Forms.TextBox();
            this.TB_ReasonBonus = new System.Windows.Forms.TextBox();
            this.B_Bonus = new System.Windows.Forms.Button();
            this.L_Timer = new System.Windows.Forms.Label();
            this.B_Start = new System.Windows.Forms.Button();
            this.B_Setup = new System.Windows.Forms.Button();
            this.B_Help = new System.Windows.Forms.Button();
            this.CB_Date = new System.Windows.Forms.ComboBox();
            this.LB_History = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.setthelp = new System.Windows.Forms.ToolTip(this.components);
            this.helphelp = new System.Windows.Forms.ToolTip(this.components);
            this.Evahelp = new System.Windows.Forms.ToolTip(this.components);
            this.namhelp = new System.Windows.Forms.ToolTip(this.components);
            this.procevahelp = new System.Windows.Forms.ToolTip(this.components);
            this.bonhelp = new System.Windows.Forms.ToolTip(this.components);
            this.commhelp = new System.Windows.Forms.ToolTip(this.components);
            this.bonprochelp = new System.Windows.Forms.ToolTip(this.components);
            this.totalhelp = new System.Windows.Forms.ToolTip(this.components);
            this.datehelp = new System.Windows.Forms.ToolTip(this.components);
            this.hishelp = new System.Windows.Forms.ToolTip(this.components);
            this.timehelp = new System.Windows.Forms.ToolTip(this.components);
            this.Starthelp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // B_Eva
            // 
            this.B_Eva.BackColor = System.Drawing.Color.White;
            this.B_Eva.BackgroundImage = global::Sentinel.Properties.Resources.B_25x25_OK;
            this.B_Eva.FlatAppearance.BorderSize = 0;
            this.B_Eva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Eva.Location = new System.Drawing.Point(293, 95);
            this.B_Eva.Name = "B_Eva";
            this.B_Eva.Size = new System.Drawing.Size(25, 25);
            this.B_Eva.TabIndex = 0;
            this.procevahelp.SetToolTip(this.B_Eva, "Подтверждение ввода оценки");
            this.B_Eva.UseVisualStyleBackColor = false;
            this.B_Eva.Click += new System.EventHandler(this.B_Eva_Click);
            // 
            // TB_Eva
            // 
            this.TB_Eva.Location = new System.Drawing.Point(25, 98);
            this.TB_Eva.Name = "TB_Eva";
            this.TB_Eva.Size = new System.Drawing.Size(22, 20);
            this.TB_Eva.TabIndex = 1;
            this.Evahelp.SetToolTip(this.TB_Eva, "Ввод оценки (1 - 12)");
            this.TB_Eva.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Eva_KeyDown);
            // 
            // CB_Less
            // 
            this.CB_Less.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_Less.FormattingEnabled = true;
            this.CB_Less.Location = new System.Drawing.Point(87, 98);
            this.CB_Less.Name = "CB_Less";
            this.CB_Less.Size = new System.Drawing.Size(200, 21);
            this.CB_Less.TabIndex = 2;
            this.namhelp.SetToolTip(this.CB_Less, "Выбор предмета");
            // 
            // L_Total
            // 
            this.L_Total.AutoSize = true;
            this.L_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.L_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Total.ForeColor = System.Drawing.Color.White;
            this.L_Total.Location = new System.Drawing.Point(126, 235);
            this.L_Total.Name = "L_Total";
            this.L_Total.Size = new System.Drawing.Size(38, 16);
            this.L_Total.TabIndex = 3;
            this.L_Total.Text = "total";
            this.totalhelp.SetToolTip(this.L_Total, "Количество кредитов");
            // 
            // TB_Bonus
            // 
            this.TB_Bonus.Location = new System.Drawing.Point(25, 184);
            this.TB_Bonus.Name = "TB_Bonus";
            this.TB_Bonus.Size = new System.Drawing.Size(40, 20);
            this.TB_Bonus.TabIndex = 5;
            this.bonhelp.SetToolTip(this.TB_Bonus, "Ввод бонуса (1) или штрафа (-1)");
            this.TB_Bonus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Bonus_KeyDown);
            // 
            // TB_ReasonBonus
            // 
            this.TB_ReasonBonus.Location = new System.Drawing.Point(108, 184);
            this.TB_ReasonBonus.Name = "TB_ReasonBonus";
            this.TB_ReasonBonus.Size = new System.Drawing.Size(179, 20);
            this.TB_ReasonBonus.TabIndex = 6;
            this.commhelp.SetToolTip(this.TB_ReasonBonus, "Комментарий к бонусу");
            this.TB_ReasonBonus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_ReasonBonus_KeyDown);
            // 
            // B_Bonus
            // 
            this.B_Bonus.BackColor = System.Drawing.Color.White;
            this.B_Bonus.BackgroundImage = global::Sentinel.Properties.Resources.B_25x25_OK;
            this.B_Bonus.FlatAppearance.BorderSize = 0;
            this.B_Bonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Bonus.Location = new System.Drawing.Point(293, 181);
            this.B_Bonus.Name = "B_Bonus";
            this.B_Bonus.Size = new System.Drawing.Size(25, 25);
            this.B_Bonus.TabIndex = 7;
            this.bonprochelp.SetToolTip(this.B_Bonus, "Подтверждение ввода бонусов или штрафов");
            this.B_Bonus.UseVisualStyleBackColor = false;
            this.B_Bonus.Click += new System.EventHandler(this.B_Bonus_Click);
            // 
            // L_Timer
            // 
            this.L_Timer.AutoSize = true;
            this.L_Timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.L_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Timer.ForeColor = System.Drawing.Color.White;
            this.L_Timer.Location = new System.Drawing.Point(15, 282);
            this.L_Timer.Name = "L_Timer";
            this.L_Timer.Size = new System.Drawing.Size(37, 16);
            this.L_Timer.TabIndex = 8;
            this.L_Timer.Text = "time";
            this.timehelp.SetToolTip(this.L_Timer, "Остаток бонусного времени");
            // 
            // B_Start
            // 
            this.B_Start.BackgroundImage = global::Sentinel.Properties.Resources.B_80x35_Start;
            this.B_Start.FlatAppearance.BorderSize = 0;
            this.B_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Start.Location = new System.Drawing.Point(238, 271);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(80, 35);
            this.B_Start.TabIndex = 9;
            this.Starthelp.SetToolTip(this.B_Start, "Начало работы");
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // B_Setup
            // 
            this.B_Setup.BackgroundImage = global::Sentinel.Properties.Resources.B_25x25_Set;
            this.B_Setup.FlatAppearance.BorderSize = 0;
            this.B_Setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Setup.Location = new System.Drawing.Point(12, 12);
            this.B_Setup.Name = "B_Setup";
            this.B_Setup.Size = new System.Drawing.Size(25, 25);
            this.B_Setup.TabIndex = 10;
            this.setthelp.SetToolTip(this.B_Setup, "Настройки");
            this.B_Setup.UseVisualStyleBackColor = true;
            this.B_Setup.Click += new System.EventHandler(this.B_Setup_Click);
            // 
            // B_Help
            // 
            this.B_Help.BackgroundImage = global::Sentinel.Properties.Resources.B_25x25_Help;
            this.B_Help.FlatAppearance.BorderSize = 0;
            this.B_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Help.Location = new System.Drawing.Point(43, 12);
            this.B_Help.Name = "B_Help";
            this.B_Help.Size = new System.Drawing.Size(25, 25);
            this.B_Help.TabIndex = 11;
            this.helphelp.SetToolTip(this.B_Help, "Помощь");
            this.B_Help.UseVisualStyleBackColor = true;
            // 
            // CB_Date
            // 
            this.CB_Date.FormattingEnabled = true;
            this.CB_Date.Location = new System.Drawing.Point(331, 24);
            this.CB_Date.Name = "CB_Date";
            this.CB_Date.Size = new System.Drawing.Size(261, 21);
            this.CB_Date.TabIndex = 13;
            this.CB_Date.Text = "01.01.2001";
            this.datehelp.SetToolTip(this.CB_Date, "Выбор даты истории");
            this.CB_Date.SelectedIndexChanged += new System.EventHandler(this.CB_Date_SelectedIndexChanged);
            // 
            // LB_History
            // 
            this.LB_History.FormattingEnabled = true;
            this.LB_History.Location = new System.Drawing.Point(331, 51);
            this.LB_History.Name = "LB_History";
            this.LB_History.Size = new System.Drawing.Size(261, 251);
            this.LB_History.TabIndex = 14;
            this.hishelp.SetToolTip(this.LB_History, "Вывод истории за выбраный день");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ввод оценок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Балы:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Предмет:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Кредиты:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(105, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Примечание:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ввод бонусов и штрафов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(328, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "История:";
            // 
            // Gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sentinel.Properties.Resources.Gen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(600, 310);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LB_History);
            this.Controls.Add(this.CB_Date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Help);
            this.Controls.Add(this.B_Setup);
            this.Controls.Add(this.B_Start);
            this.Controls.Add(this.L_Timer);
            this.Controls.Add(this.B_Bonus);
            this.Controls.Add(this.TB_ReasonBonus);
            this.Controls.Add(this.TB_Bonus);
            this.Controls.Add(this.L_Total);
            this.Controls.Add(this.CB_Less);
            this.Controls.Add(this.TB_Eva);
            this.Controls.Add(this.B_Eva);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentinel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gen_FormClosing);
            this.Load += new System.EventHandler(this.Gen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Eva;
        public System.Windows.Forms.TextBox TB_Eva;
        public System.Windows.Forms.ComboBox CB_Less;
        public System.Windows.Forms.Label L_Total;
        public System.Windows.Forms.TextBox TB_Bonus;
        public System.Windows.Forms.TextBox TB_ReasonBonus;
        private System.Windows.Forms.Button B_Bonus;
        public System.Windows.Forms.Label L_Timer;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.Button B_Setup;
        private System.Windows.Forms.Button B_Help;
        public System.Windows.Forms.ComboBox CB_Date;
        public System.Windows.Forms.ListBox LB_History;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip procevahelp;
        private System.Windows.Forms.ToolTip Evahelp;
        private System.Windows.Forms.ToolTip namhelp;
        private System.Windows.Forms.ToolTip totalhelp;
        private System.Windows.Forms.ToolTip bonhelp;
        private System.Windows.Forms.ToolTip commhelp;
        private System.Windows.Forms.ToolTip bonprochelp;
        private System.Windows.Forms.ToolTip timehelp;
        private System.Windows.Forms.ToolTip Starthelp;
        private System.Windows.Forms.ToolTip setthelp;
        private System.Windows.Forms.ToolTip helphelp;
        private System.Windows.Forms.ToolTip datehelp;
        private System.Windows.Forms.ToolTip hishelp;
    }
}

