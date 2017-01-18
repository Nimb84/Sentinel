namespace Sentinel
{
    partial class Repass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repass));
            this.TB_Repass = new System.Windows.Forms.TextBox();
            this.TB_Repass2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.B_Cansel = new System.Windows.Forms.Button();
            this.L_PassEnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Repass
            // 
            this.TB_Repass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Repass.Location = new System.Drawing.Point(12, 25);
            this.TB_Repass.Name = "TB_Repass";
            this.TB_Repass.Size = new System.Drawing.Size(156, 20);
            this.TB_Repass.TabIndex = 0;
            this.TB_Repass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Repass2
            // 
            this.TB_Repass2.Location = new System.Drawing.Point(12, 73);
            this.TB_Repass2.Name = "TB_Repass2";
            this.TB_Repass2.Size = new System.Drawing.Size(156, 20);
            this.TB_Repass2.TabIndex = 1;
            this.TB_Repass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Sentinel.Properties.Resources.B_80x25;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(84, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_Cansel
            // 
            this.B_Cansel.BackgroundImage = global::Sentinel.Properties.Resources.B_80x25;
            this.B_Cansel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Cansel.FlatAppearance.BorderSize = 0;
            this.B_Cansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Cansel.Location = new System.Drawing.Point(12, 99);
            this.B_Cansel.Name = "B_Cansel";
            this.B_Cansel.Size = new System.Drawing.Size(60, 25);
            this.B_Cansel.TabIndex = 3;
            this.B_Cansel.Text = "Отмена";
            this.B_Cansel.UseVisualStyleBackColor = true;
            this.B_Cansel.Click += new System.EventHandler(this.B_Cansel_Click);
            // 
            // L_PassEnt
            // 
            this.L_PassEnt.AutoSize = true;
            this.L_PassEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_PassEnt.ForeColor = System.Drawing.Color.White;
            this.L_PassEnt.Location = new System.Drawing.Point(9, 9);
            this.L_PassEnt.Name = "L_PassEnt";
            this.L_PassEnt.Size = new System.Drawing.Size(143, 13);
            this.L_PassEnt.TabIndex = 4;
            this.L_PassEnt.Text = "Введите новый пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Повторите ввод пароля";
            // 
            // Repass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Sentinel.Properties.Resources.RePass;
            this.ClientSize = new System.Drawing.Size(180, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_PassEnt);
            this.Controls.Add(this.B_Cansel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_Repass2);
            this.Controls.Add(this.TB_Repass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Repass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repass";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Repass_FormClosed);
            this.Load += new System.EventHandler(this.Repass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Repass;
        private System.Windows.Forms.TextBox TB_Repass2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button B_Cansel;
        private System.Windows.Forms.Label L_PassEnt;
        private System.Windows.Forms.Label label1;
    }
}