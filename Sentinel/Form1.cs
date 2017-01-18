using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Sentinel
{
    public partial class Gen : Form
    {
        //создание делегата для доступа к форме из других потов
        public delegate void InvokeDelegate();

        //стандартная строка инициализации компонентов формы
        public Gen()
        {
            InitializeComponent();
        }

            //при загрузке формы
        private void Gen_Load(object sender, EventArgs e)
        {
            Global.first = Initials.FirstStart();
            //проверка первого запуска(общего)
            if (Global.first)
            {
                //остановка доп.таймера
                Global.AdminOn = true;
                //Открытие АдминФормы
                Admin Admfrm = new Admin();
                Admfrm.Show();
                //BeginInvoke(new InvokeDelegate(HideGen));
            }

            //инит дейт
            Global.date = Initials.InitialDate("yyMMdd");
                //проверка первого запуска (макет) (раз в день)
            Initials.CheckFirstStart();
                //инициализация предметов в комбобокс 
            ActionsForms.InitLessGen(this);
                //обновление значение кредитов на форме
            ActionsForms.TotalDisplay(this);
                // 
            ActionsForms.InitListHis(this, Global.date);
            //инициализация файловых имен в комбобокс
            ActionsForms.InitComboFileName(this);
            //в комбобоксе, при появлении показывает именно дату запуска
            CB_Date.Text = Initials.InitialDate("dd.MM.yy");

            //загрузка данных пароля
            Initials.InitPassAtt();

            //запуск потока отчета дополнительного времени
            Thread StartTimerStarted = new Thread(StartTimer);
            StartTimerStarted.Start();
            
        }

            //кнопка ввода оценок
        private void B_Eva_Click(object sender, EventArgs e)
        {
                //преобразование оценок в кредиты и добавление в фаил истории
            ActionsForms.DataEva(this);
                //обновление истории
            ActionsForms.RefHis(this);
        }

            //кнопка ввода бонусов
        private void B_Bonus_Click(object sender, EventArgs e)
        {
                //добавление кредитов и добавление в фаил истории
            ActionsForms.DataBonus(this);
            //обновлеине истории
            ActionsForms.RefHis(this);
        }

        //кнопка досрочного завершения ввода оценок
        private void B_Start_Click(object sender, EventArgs e)
        {
            //выход из формы и переход в рабочий режим
            StartWork();
        }

        //кнопка настроек
        private void B_Setup_Click(object sender, EventArgs e)
        {
            if (!Global.settShow)
            {
                //булевое открытия формы
                Global.settShow = true;
                //создание и показ формы
                Setting Settfrm = new Setting();
                Settfrm.Show();
            }
        }

        //выбор даты в комбоксе, для отображения истории другого дня
        private void CB_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            //преобразует выбор в стоку
            string date = CB_Date.SelectedItem.ToString();
            //(тестово)преобразует "красивый вид" в НУЖНЫЙ текст (название файла того дня)
            string Mdate = string.Format("{0}{1}{2}{3}{4}{5}",
                    date[6], date[7], date[3], date[4],
                    date[0], date[1]);
            //показывает историю
            ActionsForms.InitListHis(this, Mdate);
        }

        //стартовый таймер ввода оценок
        public void StartTimer()
        {
            //сам таймер
            for (int i = Global.bonustimer; i > 0; i--)//
            {
                //при включении админформы таймер "замирает"
                if (Global.AdminOn && !Global.exit)
                {
                    i++;
                    //скрытие главной формы
                    BeginInvoke(new InvokeDelegate(HideGen));
                }
                //посекундный отсчет
                if (!Global.infoShow && !Global.exit)
                {
                    //преобразование таймера в минуты
                    int min = i / 60;
                    //в секунды
                    int sec = i % 60;
                    //для красивого выводы
                    if (sec < 10)
                        Global.time = String.Format("0{0}:0{1}", min, sec);
                    else
                        Global.time = String.Format("0{0}:{1}", min, sec);
                    //обновление таймера на форме
                    if (!Global.infoShow && !Global.exit)
                        L_Timer.BeginInvoke(new InvokeDelegate(RefreshTimer));
                    //остановка потока
                    Thread.Sleep(1000);
                }
            }
            //после окончания стартового таймера 
            if (!Global.exit)
            {
                //переход в рабочий режим
                BeginInvoke(new InvokeDelegate(StartWork));
                //запуск потока главного таймера
                Thread GeneralTimerStarted = new Thread(GenTimer);
                GeneralTimerStarted.Start();
            }
            
        }

        //главный таймер
        public void GenTimer()
        {
            //тест ! для избежание какого-то непонятного бага
            Global.total += Work.CountTotal(Global.timer);
            //дает первые записи (для избежания бага отображения в истории)
            Work.WriteHis("Программа проработала 0 минут. (-0 k)");
            Work.WriteHis(String.Format("Осталось {0} k", Global.total));
            Global.settShow = false;
            Global.Start = true;
            //работа таймера
            while (true)
            {
                //проверяет срабатывание таймера оповещения (установленого пользователем)
                if (Global.timer == Global.playtime + Global.StartTimer && Global.tumbpltm)
                {
                    //открывает поток отображения уведомления таймера
                    Thread SM = new Thread(ShowMess);
                    SM.Start();
                }

                //отделяет часы и минуты
                int hh = Global.timer / 60;
                int min = Global.timer % 60;
                
                //для красивой картинки
                if (min < 10)
                    Global.time = String.Format("0{0}:0{1}", hh, min);
                else
                    Global.time = String.Format("0{0}:{1}", hh, min);
                
                //отправляет сколько часов сыграно (для расчета)
                Global.cost = Work.CountTotal(Global.timer);
                
                //собственно отнятие от общего счета
                Global.total -= Global.cost;

                //обновление счета
                Work.WriteTotal();
                //узнает стоимость игры
                int TotalCost = Work.CostGameTime(Global.timer);
                //отправляет количество минут для формирования строки игры
                string result = String.Format("Программа проработала {0} минут. (-{1} k)",
                                Global.timer-Global.StartTimer, TotalCost-Global.StartScore);
                //формирует строку остатка
                string total = String.Format("Остаток {0} k", Global.total);
                //удаление из истории 2 строки и запись проработаное время
                Work.WriteTotalHis(result);
                //запись остатка
                Work.WriteHis(total);
                //записывает таймер в фаил
                Work.WriteTimer(Global.timer);
                //поминутный расчет
                System.Threading.Thread.Sleep(60000);
                Global.timer++;
            }
        }

            //при запуске основного таймера
        public void StartWork()
        {
                //отображает информационную форму
            Work.InfoShow();
                //закрывает эту
            BeginInvoke(new InvokeDelegate(HideGen));
        }

        //Для делегата! работа с формой (скрытие)
        public void HideGen() { Hide(); }

        //обновление таймера
        public void RefreshTimer() { L_Timer.Text = Global.time; }


        //показ сообщение с таймера пользователя
        public void ShowMess() { MessageBox.Show(String.Format("Прошло {0} минут!", Global.playtime)); }

        //Срабатывание кнопок при нажатии Enter
        private void TB_ReasonBonus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                B_Bonus_Click(sender, e);
            }
        }
        //
        private void TB_Bonus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                B_Bonus_Click(sender, e);
            }
        }
        //
        private void TB_Eva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                B_Eva_Click(sender, e);
            }
        }
        //во избежание закрытия формы
        private void Gen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global.exit)
            {
                //отмена закрытия
                e.Cancel = true;
                //вывод сообщения
                MessageBox.Show("Не так быстро, дружок");
                //запись в историю
                Work.WriteHis(Initials.InitialDate("HH:mm") + "  Попытка закрытия приложения");
                //обновление истории
                ActionsForms.RefHis(this);
            }
                
        }
    }
}