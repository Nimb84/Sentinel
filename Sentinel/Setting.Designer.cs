namespace Sentinel
{
    partial class Setting
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
            this.TB_Pass = new System.Windows.Forms.TextBox();
            this.B_Ok = new System.Windows.Forms.Button();
            this.ChB_PlayTimer = new System.Windows.Forms.CheckBox();
            this.TB_PlayTimer = new System.Windows.Forms.TextBox();
            this.L_min = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            this.L_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Pass
            // 
            this.TB_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Pass.Location = new System.Drawing.Point(78, 89);
            this.TB_Pass.Name = "TB_Pass";
            this.TB_Pass.Size = new System.Drawing.Size(100, 20);
            this.TB_Pass.TabIndex = 0;
            this.TB_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // B_Ok
            // 
            this.B_Ok.BackgroundImage = global::Sentinel.Properties.Resources.B_80x25;
            this.B_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Ok.FlatAppearance.BorderSize = 0;
            this.B_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Ok.Location = new System.Drawing.Point(85, 115);
            this.B_Ok.Name = "B_Ok";
            this.B_Ok.Size = new System.Drawing.Size(85, 25);
            this.B_Ok.TabIndex = 2;
            this.B_Ok.Text = "Подтвердить";
            this.B_Ok.UseVisualStyleBackColor = true;
            this.B_Ok.Click += new System.EventHandler(this.B_Ok_Click);
            // 
            // ChB_PlayTimer
            // 
            this.ChB_PlayTimer.AutoSize = true;
            this.ChB_PlayTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChB_PlayTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChB_PlayTimer.ForeColor = System.Drawing.Color.White;
            this.ChB_PlayTimer.Location = new System.Drawing.Point(13, 38);
            this.ChB_PlayTimer.Name = "ChB_PlayTimer";
            this.ChB_PlayTimer.Size = new System.Drawing.Size(161, 17);
            this.ChB_PlayTimer.TabIndex = 3;
            this.ChB_PlayTimer.Text = "Напомнить мне через:";
            this.ChB_PlayTimer.UseVisualStyleBackColor = false;
            this.ChB_PlayTimer.Click += new System.EventHandler(this.ChB_PlayTimer_Click);
            // 
            // TB_PlayTimer
            // 
            this.TB_PlayTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_PlayTimer.BackColor = System.Drawing.SystemColors.Window;
            this.TB_PlayTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_PlayTimer.Location = new System.Drawing.Point(172, 36);
            this.TB_PlayTimer.Name = "TB_PlayTimer";
            this.TB_PlayTimer.Size = new System.Drawing.Size(26, 20);
            this.TB_PlayTimer.TabIndex = 4;
            this.TB_PlayTimer.Text = "10";
            // 
            // L_min
            // 
            this.L_min.AutoSize = true;
            this.L_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.L_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_min.ForeColor = System.Drawing.Color.White;
            this.L_min.Location = new System.Drawing.Point(198, 39);
            this.L_min.Name = "L_min";
            this.L_min.Size = new System.Drawing.Size(42, 13);
            this.L_min.TabIndex = 5;
            this.L_min.Text = "минут";
            // 
            // B_Close
            // 
            this.B_Close.BackgroundImage = global::Sentinel.Properties.Resources.X;
            this.B_Close.FlatAppearance.BorderSize = 0;
            this.B_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Close.Location = new System.Drawing.Point(223, 2);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(20, 20);
            this.B_Close.TabIndex = 6;
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // L_text
            // 
            this.L_text.AutoSize = true;
            this.L_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.L_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_text.ForeColor = System.Drawing.Color.White;
            this.L_text.Location = new System.Drawing.Point(12, 69);
            this.L_text.Name = "L_text";
            this.L_text.Size = new System.Drawing.Size(169, 13);
            this.L_text.TabIndex = 7;
            this.L_text.Text = "Административный режим:";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sentinel.Properties.Resources.Sett;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(245, 150);
            this.Controls.Add(this.L_text);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.L_min);
            this.Controls.Add(this.TB_PlayTimer);
            this.Controls.Add(this.ChB_PlayTimer);
            this.Controls.Add(this.B_Ok);
            this.Controls.Add(this.TB_Pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.Text = "Setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Setting_FormClosed);
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Pass;
        private System.Windows.Forms.Button B_Ok;
        private System.Windows.Forms.CheckBox ChB_PlayTimer;
        private System.Windows.Forms.TextBox TB_PlayTimer;
        private System.Windows.Forms.Label L_min;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Label L_text;
    }
}