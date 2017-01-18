using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Sentinel
{
    public partial class InfoForm : Form
    {
            //делегат для роаботы с разными потоками
        public delegate void InvokeDelegate();

        public InfoForm()
        {
            //иициализация и задание стартовой точки появления (слевый нижний угол)
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - 40);
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            //поток обновление показателей на форме
            Thread Refresh = new Thread(StartThread);
            Refresh.Start();
            L_cost.Text = (Global.cost).ToString() + " k/мин";
            L_time.Text = Global.time;
            L_total.Text = (Global.total).ToString() + " k";
        }

        private void StartThread()
        {
            
            //обновление показателей
            while (Global.infoShow)
            {
                L_cost.BeginInvoke(new InvokeDelegate(RefCost));
                L_time.BeginInvoke(new InvokeDelegate(RefTime));
                L_total.BeginInvoke(new InvokeDelegate(RefTotal));
                Thread.Sleep(1000);
            }
        }

        //для делегатов
        private void RefCost() { L_cost.Text = (Global.cost).ToString() + " k/мин"; }
        //
        private void RefTime() { L_time.Text = Global.time; }
        //
        private void RefTotal() { L_total.Text = (Global.total).ToString() + " k"; }

        //запрещает закрытьвать форму
        private void InfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global.exit)
            {
                e.Cancel = true;
                MessageBox.Show("Недостаточно прав");
            }
        }
    }
}
