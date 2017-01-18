using System.IO;
using System.Windows.Forms;

namespace Sentinel
{
    class Global
    {
            //определяет путь приложения
        public static string path = Application.StartupPath.ToString() + @"\Data\";
        //булевая первичного запуска (общего)
        public static bool first = true;

            //считывает общий счет кредитов
        public static int total = Initials.InitTotal();
            //определяет дату включение приложения (поменян порядок, для правильной сортировки историй)
        public static string date = "yyMMdd";
            //главный таймер
        public static int timer = 0;
            //бонусный таймер (в сек)
        public static int bonustimer = 420;
            //стоимость минуты
        public static int cost = 3;
            //таймер
        public static string time = "null";

            //перменные персонального таймера
        public static int playtime = 30;
            //вкл выкл таймера
        public static bool tumbpltm= false;
        public static bool Start = false;
        public static bool AdminOn = false;

            //запоминает, сколько уже было наиграно за пред. сеанс
        public static int StartTimer = 0;
        public static int StartScore = 0;

        //булевые показа информационной панели
        public static bool infoShow = false;
        //настроек
        public static bool settShow = false;

        public static bool exit = false;


    }

    class Passwosd
    {
        public static string pass = null;
        //количество попыток ввода пароля
        public static int NumAttempts = 0;

        public static bool repass = false;

        //перезапись пароля
        public static void ReUnitPass()
        {
            string fpath = Global.path + @"base\passatt.txt";
            StreamWriter fwrite = new StreamWriter(fpath, false, System.Text.Encoding.UTF8);
            fwrite.WriteLine(pass);
            fwrite.WriteLine(3);
            fwrite.Close();
        }
    }
}
