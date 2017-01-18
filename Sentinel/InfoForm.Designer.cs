namespace Sentinel
{
    partial class InfoForm
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
            this.components = new System.ComponentModel.Container();
            this.L_cost = new System.Windows.Forms.Label();
            this.L_time = new System.Windows.Forms.Label();
            this.L_total = new System.Windows.Forms.Label();
            this.TotalHelp = new System.Windows.Forms.ToolTip(this.components);
            this.timehelp = new System.Windows.Forms.ToolTip(this.components);
            this.costhelp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // L_cost
            // 
            this.L_cost.AutoSize = true;
            this.L_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_cost.ForeColor = System.Drawing.Color.White;
            this.L_cost.Location = new System.Drawing.Point(7, 9);
            this.L_cost.Name = "L_cost";
            this.L_cost.Size = new System.Drawing.Size(43, 20);
            this.L_cost.TabIndex = 0;
            this.L_cost.Text = "cost";
            this.costhelp.SetToolTip(this.L_cost, "Текущая стоимость минуты");
            // 
            // L_time
            // 
            this.L_time.AutoSize = true;
            this.L_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_time.ForeColor = System.Drawing.Color.White;
            this.L_time.Location = new System.Drawing.Point(7, 41);
            this.L_time.Name = "L_time";
            this.L_time.Size = new System.Drawing.Size(43, 20);
            this.L_time.TabIndex = 1;
            this.L_time.Text = "time";
            this.timehelp.SetToolTip(this.L_time, "Общее время работы программы (за день)");
            // 
            // L_total
            // 
            this.L_total.AutoSize = true;
            this.L_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_total.ForeColor = System.Drawing.Color.White;
            this.L_total.Location = new System.Drawing.Point(114, 41);
            this.L_total.Name = "L_total";
            this.L_total.Size = new System.Drawing.Size(45, 20);
            this.L_total.TabIndex = 2;
            this.L_total.Text = "total";
            this.L_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TotalHelp.SetToolTip(this.L_total, "Остаток кредитов");
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Sentinel.Properties.Resources.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(200, 70);
            this.Controls.Add(this.L_total);
            this.Controls.Add(this.L_time);
            this.Controls.Add(this.L_cost);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoForm_FormClosing);
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_cost;
        private System.Windows.Forms.Label L_time;
        private System.Windows.Forms.Label L_total;
        private System.Windows.Forms.ToolTip costhelp;
        private System.Windows.Forms.ToolTip timehelp;
        private System.Windows.Forms.ToolTip TotalHelp;
    }
}