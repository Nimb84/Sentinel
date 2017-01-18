namespace Sentinel
{
    partial class Admin
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
            this.B_ShowPass = new System.Windows.Forms.Button();
            this.L_Pass = new System.Windows.Forms.Label();
            this.B_RePass = new System.Windows.Forms.Button();
            this.B_Sell = new System.Windows.Forms.Button();
            this.TB_EvaCost = new System.Windows.Forms.TextBox();
            this.CB_Eva = new System.Windows.Forms.ComboBox();
            this.B_Play = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.B_DelLess = new System.Windows.Forms.Button();
            this.B_PlusLess = new System.Windows.Forms.Button();
            this.TB_Less = new System.Windows.Forms.TextBox();
            this.LB_Less = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_ShowPass
            // 
            this.B_ShowPass.BackgroundImage = global::Sentinel.Properties.Resources.B_25x25_See;
            this.B_ShowPass.FlatAppearance.BorderSize = 0;
            this.B_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ShowPass.Location = new System.Drawing.Point(82, 334);
            this.B_ShowPass.Name = "B_ShowPass";
            this.B_ShowPass.Size = new System.Drawing.Size(25, 25);
            this.B_ShowPass.TabIndex = 1;
            this.B_ShowPass.UseVisualStyleBackColor = true;
            this.B_ShowPass.Click += new System.EventHandler(this.B_ShowPass_Click);
            // 
            // L_Pass
            // 
            this.L_Pass.AutoSize = true;
            this.L_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Pass.ForeColor = System.Drawing.Color.White;
            this.L_Pass.Location = new System.Drawing.Point(12, 340);
            this.L_Pass.Name = "L_Pass";
            this.L_Pass.Size = new System.Drawing.Size(0, 13);
            this.L_Pass.TabIndex = 3;
            // 
            // B_RePass
            // 
            this.B_RePass.BackgroundImage = global::Sentinel.Properties.Resources.B_80x25;
            this.B_RePass.FlatAppearance.BorderSize = 0;
            this.B_RePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_RePass.Location = new System.Drawing.Point(113, 333);
            this.B_RePass.Name = "B_RePass";
            this.B_RePass.Size = new System.Drawing.Size(80, 25);
            this.B_RePass.TabIndex = 2;
            this.B_RePass.Text = "Изменить";
            this.B_RePass.UseVisualStyleBackColor = true;
            this.B_RePass.Click += new System.EventHandler(this.B_RePass_Click);
            // 
            // B_Sell
            // 
            this.B_Sell.BackColor = System.Drawing.Color.Gray;
            this.B_Sell.BackgroundImage = global::Sentinel.Properties.Resources.B_80x25;
            this.B_Sell.FlatAppearance.BorderSize = 0;
            this.B_Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Sell.ForeColor = System.Drawing.Color.Black;
            this.B_Sell.Location = new System.Drawing.Point(113, 53);
            this.B_Sell.Name = "B_Sell";
            this.B_Sell.Size = new System.Drawing.Size(80, 25);
            this.B_Sell.TabIndex = 3;
            this.B_Sell.Text = "Изменить";
            this.B_Sell.UseVisualStyleBackColor = false;
            this.B_Sell.Click += new System.EventHandler(this.B_Sell_Click);
            // 
            // TB_EvaCost
            // 
            this.TB_EvaCost.Location = new System.Drawing.Point(72, 25);
            this.TB_EvaCost.Name = "TB_EvaCost";
            this.TB_EvaCost.Size = new System.Drawing.Size(95, 20);
            this.TB_EvaCost.TabIndex = 1;
            // 
            // CB_Eva
            // 
            this.CB_Eva.FormattingEnabled = true;
            this.CB_Eva.Location = new System.Drawing.Point(11, 25);
            this.CB_Eva.Name = "CB_Eva";
            this.CB_Eva.Size = new System.Drawing.Size(54, 21);
            this.CB_Eva.TabIndex = 0;
            this.CB_Eva.Text = "1";
            this.CB_Eva.SelectedIndexChanged += new System.EventHandler(this.CB_Eva_SelectedIndexChanged);
            // 
            // B_Play
            // 
            this.B_Play.BackgroundImage = global::Sentinel.Properties.Resources.B_80x25;
            this.B_Play.FlatAppearance.BorderSize = 0;
            this.B_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Play.ForeColor = System.Drawing.Color.Black;
            this.B_Play.Location = new System.Drawing.Point(113, 388);
            this.B_Play.Name = "B_Play";
            this.B_Play.Size = new System.Drawing.Size(80, 25);
            this.B_Play.TabIndex = 4;
            this.B_Play.Text = "Продолжить";
            this.B_Play.UseVisualStyleBackColor = true;
            this.B_Play.Click += new System.EventHandler(this.B_Play_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.BackgroundImage = global::Sentinel.Properties.Resources.B_80x35;
            this.B_Exit.FlatAppearance.BorderSize = 0;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Location = new System.Drawing.Point(11, 383);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(80, 35);
            this.B_Exit.TabIndex = 5;
            this.B_Exit.Text = "Выход из программы";
            this.B_Exit.UseVisualStyleBackColor = true;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // B_DelLess
            // 
            this.B_DelLess.BackgroundImage = global::Sentinel.Properties.Resources.B_25x25_M;
            this.B_DelLess.FlatAppearance.BorderSize = 0;
            this.B_DelLess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_DelLess.Location = new System.Drawing.Point(164, 100);
            this.B_DelLess.Name = "B_DelLess";
            this.B_DelLess.Size = new System.Drawing.Size(25, 25);
            this.B_DelLess.TabIndex = 3;
            this.B_DelLess.UseVisualStyleBackColor = true;
            this.B_DelLess.Click += new System.EventHandler(this.B_DelLess_Click);
            // 
            // B_PlusLess
            // 
            this.B_PlusLess.BackgroundImage = global::Sentinel.Properties.Resources.B_25x25_P;
            this.B_PlusLess.FlatAppearance.BorderSize = 0;
            this.B_PlusLess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_PlusLess.Location = new System.Drawing.Point(132, 100);
            this.B_PlusLess.Name = "B_PlusLess";
            this.B_PlusLess.Size = new System.Drawing.Size(25, 25);
            this.B_PlusLess.TabIndex = 2;
            this.B_PlusLess.UseVisualStyleBackColor = true;
            this.B_PlusLess.Click += new System.EventHandler(this.B_PlusLess_Click);
            // 
            // TB_Less
            // 
            this.TB_Less.Location = new System.Drawing.Point(12, 102);
            this.TB_Less.Name = "TB_Less";
            this.TB_Less.Size = new System.Drawing.Size(114, 20);
            this.TB_Less.TabIndex = 1;
            this.TB_Less.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Less_KeyDown);
            // 
            // LB_Less
            // 
            this.LB_Less.FormattingEnabled = true;
            this.LB_Less.Location = new System.Drawing.Point(12, 127);
            this.LB_Less.Name = "LB_Less";
            this.LB_Less.Size = new System.Drawing.Size(177, 173);
            this.LB_Less.TabIndex = 0;
            this.LB_Less.SelectedIndexChanged += new System.EventHandler(this.LB_Less_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Редактирование оценок:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Редактирование предметов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Пароль:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Sentinel.Properties.Resources.Admin;
            this.ClientSize = new System.Drawing.Size(200, 425);
            this.Controls.Add(this.B_RePass);
            this.Controls.Add(this.L_Pass);
            this.Controls.Add(this.B_ShowPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_Less);
            this.Controls.Add(this.B_DelLess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_PlusLess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Less);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Sell);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.TB_EvaCost);
            this.Controls.Add(this.B_Play);
            this.Controls.Add(this.CB_Eva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_ShowPass;
        private System.Windows.Forms.Button B_RePass;
        private System.Windows.Forms.TextBox TB_EvaCost;
        public System.Windows.Forms.ComboBox CB_Eva;
        private System.Windows.Forms.Button B_Sell;
        private System.Windows.Forms.Label L_Pass;
        private System.Windows.Forms.Button B_Play;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Button B_DelLess;
        private System.Windows.Forms.Button B_PlusLess;
        public System.Windows.Forms.TextBox TB_Less;
        public System.Windows.Forms.ListBox LB_Less;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}