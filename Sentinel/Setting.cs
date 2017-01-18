using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Sentinel
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width - 301,
                Screen.PrimaryScreen.Bounds.Height / 2 - this.Height - 28);
        }
        public delegate void InvokeDelegate();

        //загрузка формы: 
        private void Setting_Load(object sender, EventArgs e)
        {
            //задание параметров тексбокса ввода пароля
            TB_Pass.PasswordChar = '*';
            TB_Pass.MaxLength = 8;

            Thread checkStart = new Thread(check);
            checkStart.Start();
        }
        //кнопка подтверждения пароля
        private void B_Ok_Click(object sender, EventArgs e)
        {
        if (TB_Pass.Text == Passwosd.pass)
        {
                //Закрытие настроек
                Close();
                Work.WriteHis(Initials.InitialDate("HH:mm") + "  Успешный вход в адм. режим");
                //остановка доп.таймера
                Global.AdminOn = true;
                //Открытие АдминФормы
                Admin Admfrm = new Admin();
                Admfrm.Show();
                Close();
        }else
            {
                Passwosd.NumAttempts--;
                if (Passwosd.NumAttempts > 0)
                {
                    MessageBox.Show(String.Format("Осталось попыток: {0}", Passwosd.NumAttempts));
                    Work.WriteHis(Initials.InitialDate("HH:mm") + "  Ошибка ввода пароля");
                }                       
            }
        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.settShow = false;
        }

        private void ChB_PlayTimer_Click(object sender, EventArgs e)
        {
            if (ChB_PlayTimer.Checked)
            {
                Global.tumbpltm = true;
                if (Int32.TryParse(TB_PlayTimer.Text, out Global.playtime))
                {
                    MessageBox.Show(String.Format("Таймер уведомит Вас через {0} минут игры", Global.playtime));
                }
                else MessageBox.Show("Таймер введен некорректно");
            }
            else
            {
                Global.tumbpltm = false;
                MessageBox.Show("Таймер отключен");
            }
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            Global.settShow = false;
            Close();
        }

        public void check()
        {
            while (Global.settShow && !Global.exit && !Global.Start)
            {
                //остановка потока
                Thread.Sleep(1000);
            }
            if (!Global.exit && !Global.settShow && !Global.AdminOn && Global.Start)
            {
                BeginInvoke(new InvokeDelegate(closeplz));
            }
        }

        public void closeplz()
        {
            Global.settShow = false;
            Close();
        }
    }
}
