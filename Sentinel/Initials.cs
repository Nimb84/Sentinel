using System;
using System.IO;

namespace Sentinel
{
    //класс инициализации главной формы
    class Initials
    {

        //инициализация первичного запуска (с вывдом формы Администратора, задание пароля и т.п.)
        public static bool FirstStart()
        {
            StreamReader rfile = new StreamReader(Global.path + @"base\first.txt", System.Text.Encoding.UTF8);
            bool first = Boolean.Parse(rfile.ReadLine());
            rfile.Close();
            //+ - показ, минус - нет (логично)
            if (first)
            {
                return true;
            }
            else
                return false;
        }

        //проверка на первичный пуск (раз в день)
        public static void CheckFirstStart()
        {
            //(тестово) проверяет наличие записи истории, если таковой нету, то создает его и записывает первую строку
            if (!File.Exists(Global.path + @"his\" + Global.date + @".txt"))
            {
                Work.WriteHis(InitialDate("HH:mm") + "  Успешный запуск");
                Work.WriteHis(String.Format("Ваш счет: {0}", Global.total));
                Work.WriteHis("");
                //сбрасываем общий таймер
                StreamWriter writer = new StreamWriter(Global.path + @"base\timer.txt", false);
                writer.WriteLine("0");
                writer.Close();
            }
            else
            {
                //ИНАЧЕ: считывание значение таймера с файла
                StreamReader sr = new StreamReader(Global.path + @"base\timer.txt", System.Text.Encoding.UTF8);
                //считывание счета и передача в основную форму
                Global.timer = Int32.Parse(sr.ReadLine());
                //закрытие потока
                sr.Close();
                //задаем значение бонусного таймера в 3 минуты и считываем уже проиграные кредиты и таймер
                Global.bonustimer = 300;
                Global.StartTimer = Global.timer;
                Global.StartScore = Work.CostGameTime(Global.StartTimer);

                Work.WriteHis("");
                Work.WriteHis(InitialDate("HH:mm") + "  Повторный запуск");
                Work.WriteHis("");
            }

        }

        //инициализация счета
        public static int InitTotal()
        {
            //задаем место нахождения главного счета
            string fpath = Global.path + @"base\total.txt";
            //открытие потока считывания файла
            StreamReader sr = new StreamReader(fpath, System.Text.Encoding.UTF8);
            //считывание счета и передача в основную форму
            int total = Int32.Parse(sr.ReadLine());
            //закрытие потока
            sr.Close();
            return total;
        }

        //инициализация предметов в массив
        public static string[] LessonsInit()
        {
            //задает путь файла
            string fpath = Global.path + @"base\lessons.txt";
            //поток чтения
            StreamReader sr = new StreamReader(fpath, System.Text.Encoding.UTF8);
            //строка чтения
            string line;

            //массив предметов
            string[] lessons = new string[1];
            int count = 1;

            //читает до "пустоты"
            while ((line = sr.ReadLine()) != null)
            {
                if (count > lessons.Length)
                    Array.Resize(ref lessons, lessons.Length + 1);
                lessons[count - 1] = line;
                count++;
            }
            //закрытие потока
            sr.Close();
            return lessons;

        }



        //позволяет узнавать сегоднешнюю дату и возвращать её в нужном фомате (ddMMyyyy)
        public static string InitialDate(string format)
        {
            //создание объекста даты и присваивает сегоднешнюю дату
            DateTime date = DateTime.Now;
            //формирует строку в заданом формате
            string dateOnly = date.ToString(format);
            return dateOnly;
        }
        //инициализация пароля
        public static void InitPassAtt()
        {
            string fpath = Global.path + @"base\passatt.txt";
            StreamReader sr = new StreamReader(fpath, System.Text.Encoding.UTF8);
            Passwosd.pass = sr.ReadLine();
            Passwosd.NumAttempts = Int32.Parse(sr.ReadLine());
            sr.Close();
        }
    }

    //класс инициализации форму истории
    class InitHistory
    {
        //Инициализация блока истории для второй формы (Хистори)
        public static string[] InitListBox(string name)
        {
            //указывает путь текстовика
            string NeedPath = @"his\" + name + @".txt";
            //полное имя пути
            string fpath = Global.path + NeedPath;
            //инициализация потока чтения
            StreamReader sr = new StreamReader(fpath, System.Text.Encoding.UTF8);
            string line;

            string[] history = new string[1];
            int count = 1;
            //читает до пустоты
            while ((line = sr.ReadLine()) != null)
            {
                //запись в листбокс
                if (count > history.Length)
                    Array.Resize(ref history, history.Length + 1);
                history[count - 1] = line;
                count++;
            }
            //закрытие потока
            sr.Close();
            return history;
        }

        //Инициализация файлов истории в комбобоксе, который позволяет смотреть историю предыдущих дней
        public static string[] InitFileName()
        {
            //путь папки
            string NeedPath = @"his\";
            //полный путь
            string fpath = Global.path + NeedPath;
            //метода позволяющий пуречисленеи каталогов
            string[] dates = new string[1];
            int count = 1;
            DirectoryInfo dir = new DirectoryInfo(fpath);
            //Для извлечения имени файла используется цикл foreach и свойство files.name 
            //(files.FullName показывает только имя, без разрешения)
            foreach (FileInfo files in dir.GetFiles("*.txt"))
            {
                //инициализирует имя файлов (ддММгг)
                string fname = Path.GetFileNameWithoutExtension(files.FullName);
                //(тестово)преобразует в "читабельны (для пользователя)" вид (дд.ММ.гг)
                string Modfname = string.Format("{0}{1}.{2}{3}.{4}{5}",
                    fname[4], fname[5], fname[2], fname[3], fname[0], fname[1]);
                //записывает дату в массив
                if (count > dates.Length)
                    Array.Resize(ref dates, dates.Length + 1);
                dates[count - 1] = Modfname;
                count++;
            }
            return dates;
        }
    }

    //класс инициализации админформы
    class InitAdmin
    {
        //инициализаци комбокса оценок
        public static void Init_CB_Eva(Admin frm)
        {
            for (int i = 0; i < 12; i++)
            {
                //инициализация оценок от 1 до 12
                frm.CB_Eva.Items.Add(i+1);
            }
        }
    }
}