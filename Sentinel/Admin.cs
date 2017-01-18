using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Sentinel
{
    public partial class Admin : Form
    {
        //создание делегата для доступа к форме из других потов
        public delegate void InvokeDelegate();

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            InitAdmin.Init_CB_Eva(this);
            TB_EvaCost.Text = Convert.ToString(Work.Eva(1));
            ActionsForms.InitLessAdmin(this);

            if (Global.first)
            {
                Global.first = false;
                //
                StreamWriter writer = new StreamWriter(Global.path + @"base\first.txt", false);
                //
                writer.WriteLine("false");
                //закрытие потока
                writer.Close();
                B_RePass_Click(sender, e);
            }

        }

        private void CB_Eva_SelectedIndexChanged(object sender, EventArgs e)
        {
            //преобразует выбор в стpоку
            int Eva = Int32.Parse(CB_Eva.SelectedItem.ToString());
            TB_EvaCost.Text = Convert.ToString(Work.Eva(Eva));
        }
        //изменение оценки
        private void B_Sell_Click(object sender, EventArgs e)
        {
            int eva = Convert.ToInt32(CB_Eva.SelectedItem.ToString());
            string cost = TB_EvaCost.Text;
            Retuning.ReEvaCost(eva, cost);
        }

        bool showpass = false;
        //кнопка показа пароля
        private void B_ShowPass_Click(object sender, EventArgs e)
        {
            if (!showpass)
            {
                L_Pass.Text = Passwosd.pass;
                showpass = true;
            }
            else
            {
                L_Pass.Text = "";
                showpass = false;
            }
        }
        //кнопка переназначения пароля
        private void B_RePass_Click(object sender, EventArgs e)
        {
            if (!Passwosd.repass)
            {
                Repass repass = new Repass();
                repass.Show();
                Passwosd.repass = true;
                BeginInvoke(new InvokeDelegate(HideFrm));
            }
        }
        //кнопка выхода из программы
        private void B_Exit_Click(object sender, EventArgs e)
        {
            Global.exit = true;
            Global.AdminOn = false;
            Application.Exit();
            
        }
        //кнопка продолжение нормальной работы
        private void B_Play_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            Global.AdminOn = false;
            Close();
            ifrm.Show();
            MessageBox.Show("Изменения вступят в силу после перезагрузки компьютера");
        }
        //не закрывает форму
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global.exit && Global.AdminOn)
            {
                e.Cancel = true;
                MessageBox.Show("Некорректный выход из программы");
            }
        }

        //кнопка добаления предмета
        private void B_PlusLess_Click(object sender, EventArgs e)
        {
            ActionsForms.LessPlus(this);
        }

        //при выборе предмета
        private void LB_Less_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_Less.Text = LB_Less.Text;
        }

        //кнопка удаления предмета
        private void B_DelLess_Click(object sender, EventArgs e)
        {
            ActionsForms.LessDel(this);
        }
        //при нажатии Enter - добавляет предмет
        private void TB_Less_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                B_PlusLess_Click(sender, e);
            }
        }

        private void HideFrm()
        {
            Hide();
        }
    }
}
