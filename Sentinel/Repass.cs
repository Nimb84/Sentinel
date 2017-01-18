using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentinel
{
    public partial class Repass : Form
    {
        public Repass()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width - 100,
            //    Screen.PrimaryScreen.Bounds.Height / 2 - this.Height - 104);
        }
        //кнопка подтверждения
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_Repass.Text == TB_Repass2.Text)
                {
                    Passwosd.pass = TB_Repass.Text;
                    Passwosd.ReUnitPass();
                    //админформа
                    Close();
                    MessageBox.Show("Пароль изменен!");
                }
            }catch
            {
                MessageBox.Show("Повторите попытку");
                TB_Repass.Clear();
                TB_Repass2.Clear();
            }
        }

        private void Repass_Load(object sender, EventArgs e)
        {
            TB_Repass.PasswordChar = '*';
            TB_Repass.MaxLength = 8;
            TB_Repass2.PasswordChar = '*';
            TB_Repass2.MaxLength = 8;


        }

        private void Repass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Passwosd.repass = false;
            Form ifrm = Application.OpenForms[1];
            ifrm.Show();
        }

        private void B_Cansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
