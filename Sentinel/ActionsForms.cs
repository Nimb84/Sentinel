using System;
using System.IO;
using System.Windows.Forms;

namespace Sentinel
{
    class ActionsForms
    {

        public static void InitLessGen(Gen frm)
        {
            //инициализация массива предметов
            string[] lessons = Initials.LessonsInit();
            for (int i = 0; i < lessons.Length; i++)
            {
                //инициализация названия предмета в комбобокс
                frm.CB_Less.Items.Add(lessons[i]);
            }
        }

        public static void InitListHis(Gen frm, string name)
        {
            //очистка листбокса
            frm.LB_History.Items.Clear();
            //инициализация массива истории
            string[] history = InitHistory.InitListBox(name);
            for (int i = 0; i < history.Length; i++)
            {
                //инициализация истории в листбокс
                frm.LB_History.Items.Add(history[i]);
            }
        }

        public static void InitComboFileName(Gen frm)
        {
            string[] names = InitHistory.InitFileName();
            for (int i = 0; i < names.Length; i++)
            {
                //инициализация других историй в комбобокс
                frm.CB_Date.Items.Add(names[i]);
            }
        }

        public static void TotalDisplay(Gen frm)
        {
            //вывод в лейбл счета + "к"
            frm.L_Total.Text = Global.total + " k";
            //записывает счет в текстовый фаил
            Work.WriteTotal();
        }

        public static void DataEva(Gen frm)
        {
            try
            {
                int evaluation = Convert.ToInt32(frm.TB_Eva.Text);
                string lessons = frm.CB_Less.SelectedItem.ToString();
                Work.EvaProc(evaluation, lessons);
                frm.TB_Eva.Clear();
                TotalDisplay(frm);
            }
            catch { MessageBox.Show("Все поля должны быть заполнены корректно"); }

        }

        public static void DataBonus(Gen frm)
        {
            int bonus = 0;
            //проверка на то, чтобы оба поля были заполнены
            if (Int32.TryParse(frm.TB_Bonus.Text, out bonus) && frm.TB_Bonus.Text != String.Empty && frm.TB_ReasonBonus.Text != String.Empty)
            {
                //для читаемости кода комментирование бонуса присвоено имя
                string comment = frm.TB_ReasonBonus.Text;
                Work.BonProc(bonus, comment);
                //обновление обсчего счета
                TotalDisplay(frm);
                //очиста двух текстбоксов
                frm.TB_Bonus.Clear();
                frm.TB_ReasonBonus.Clear();
            }
            else MessageBox.Show("Все поля должны быть заполнены корректно");
        }

        public static void RefHis(Gen frm)
        {
            //очищает листбокс
            frm.LB_History.Items.Clear();
            //переключается на сегоднешнюю дату
            frm.CB_Date.Text = Initials.InitialDate("dd.MM.yy");
            //считывает (опять) историю с файла
            ActionsForms.InitListHis(frm, Global.date);
        }

        public static void InitAdminFrm(Admin frm)
        {
            InitAdmin.Init_CB_Eva(frm);
        }

        public static void InitLessAdmin(Admin frm)
        {
            //инициализация массива предметов
            string[] lessons = Initials.LessonsInit();
            for (int i = 0; i < lessons.Length; i++)
            {
                //инициализация названия предмета в комбобокс
                frm.LB_Less.Items.Add(lessons[i]);
            }
        }

        public static void LessPlus(Admin frm)
        {
            //введеный предмет пользователя
            string searchlessons = frm.TB_Less.Text;
            //ищт строку в ЛБ
            if (searchlessons != string.Empty)
            {
                //указывает индекс найденого предмета
                int index = frm.LB_Less.FindString(searchlessons);
                //если нашло, то
                if (index != -1)
                    //выделяет предмет
                    frm.LB_Less.SetSelected(index, true);
                else
                {
                    //если не находит - добавляет в ЛБ предмет
                    frm.LB_Less.Items.Add(searchlessons);
                    string fpath = Global.path + @"base\lessons.txt";
                    TextWriter fwriter = new StreamWriter(fpath, false, System.Text.Encoding.UTF8);
                    foreach (var item in frm.LB_Less.Items)
                       fwriter.WriteLine(item.ToString());
                    fwriter.Close();
                    frm.LB_Less.Items.Clear();
                    InitLessAdmin(frm);
                }
            }
            else
            {
                MessageBox.Show("Введите предмет");
            }
        }
        public static void LessDel(Admin frm)
        {
            //введеный предмет пользователя
            string searchlessons = frm.TB_Less.Text;
            //ищт строку в ЛБ
            if (searchlessons != string.Empty)
            {
                //указывает индекс найденого предмета
                int index = frm.LB_Less.FindString(searchlessons);
                //если нашло, то
                if (index != -1)
                {
                    //удаляет предмет
                    frm.LB_Less.Items.Remove(searchlessons);
                    //перезаписывает фаил
                    string fpath = Global.path + @"base\lessons.txt";
                    TextWriter fwriter = new StreamWriter(fpath, false, System.Text.Encoding.UTF8);
                    foreach (var item in frm.LB_Less.Items)
                        fwriter.WriteLine(item.ToString());
                    fwriter.Close();
                    //обновляет листбокс
                    frm.LB_Less.Items.Clear();
                    InitLessAdmin(frm);
                }
                    
                else
                {
                    MessageBox.Show("Предмет не найден");
                }
            }
            else
            {
                MessageBox.Show("Введите предмет");
            }

            
        }
    }
}
