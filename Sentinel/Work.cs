using Sentinel;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sentinel
{
    class Work
    {
        //отображение общего счета
        public static void WriteTotal()
        {
                //определяет местоположение файла общего счета
            string fpath = Global.path + @"base\total.txt";
                //открытие потока записи в фаил общего счета
            StreamWriter writer = new StreamWriter(fpath, false);
                //перезапись значения в фаил
            writer.WriteLine(Global.total);
                //закрытие потока
            writer.Close();
        }

            //стоимость оценок
        public static int Eva(int Eva)
        {
            //путь фаийла оценок
            string fpath = Global.path + @"base\eva.txt";
            //поток чтения
            StreamReader sr = new StreamReader(fpath, System.Text.Encoding.Default);
            string line;
            int value = 0;
            //поиск строки отвечающей за каждую оценку
            for (int i = 0; i < Eva; i++)
            {
                //считывание
                line = sr.ReadLine();
                //преобразование
                value = Int32.Parse(line);
            }
            //закрытие потока
            sr.Close();
            return value;
        }

            //подсчет кредитов
        public static void EvaProc(int evaluation, string lessons)
        {
            //проверка оценки на допустимый диапазон
            if (evaluation > 0 && evaluation <= 12)
            {
                //преобразование
                int cost = Work.Eva(evaluation);
                //суммирование общего счета
                Global.total += cost;
                //формирование читабельной строки, для записи в историю
                string result = string.Format("{0,4} {1,5} k  {2}", evaluation, cost, lessons);
                //запись строки (резальт) в историю
                Work.WriteHis(result);
                //Обновление истории
            }
            else MessageBox.Show("Оценка должна быть в диапазоне от 1 до 12");
        }

        //подсчет бонусов/штрафов
        public static void BonProc(int bonus, string comment)
        {
            //суммирование обсчего счета с бонусом
            Global.total += bonus;
            //формирование строки истории (пробелы тестово)
            string result = string.Format("{0,4} k          {1}", bonus, comment);
            //инициализация в запись истории
            Work.WriteHis(result);
        }

        //Подсчет стоимости игры - переписать для большего количестка часов
        public static int CostGameTime(int Time)
        {
            int Score = 0;
            //определение вычитаных кредитов
            if (Time > 0)
            {
                if (Time <= 60)            //первый час 0-60
                    Score = Time * 3;
                else if (Time > 60 && Time <= 120)      //второй    61-120
                    Score = 180 + ((Time - 60) * 5);
                else if (Time > 120 && Time <= 180)     //третий    121-180
                    Score = 480 + ((Time - 120) * 7);
                else
                    Score = 900 + ((Time - 180) * 10);
                return Score;
            }
            else
                Score = 0;
            return Score;
            
        }

        //ой, даже не спрашивай....лааадно, расскажу:
        //первый этап - считает сколько строк в файле
        //второй этап - записывает все что в файле, кроме последних 2 строк, в ТЕМП и добавляет нужные строки
        //трейтий этап - записывает с темпа в историю
        //Переписать с появлением опыта
        public static void WriteTotalHis(string text)
        {
            //первый этап
            string fpath = Global.path + @"his\" + Global.date + @".txt";
            string temppath = Global.path + @"base\temp.txt";
            StreamReader read = new StreamReader(fpath, System.Text.Encoding.UTF8);
            int count = 0;
            string line;
            while ((line = read.ReadLine()) != null)
            {
                count++;
            }
            read.Close();

            //второй этап
            StreamReader sr = new StreamReader(fpath, System.Text.Encoding.UTF8);
            StreamWriter writer = new StreamWriter(temppath, false, System.Text.Encoding.UTF8);
            string SkanLine;
            for (int i = 0; i < count - 2 /*&& (SkanLine = sr.ReadLine()) != null*/; i++)
            {
                SkanLine = sr.ReadLine();
                writer.WriteLine(SkanLine);
            }
            writer.WriteLine(text);
            sr.Close();
            writer.Close();

            //третий этап
            StreamReader sr2 = new StreamReader(temppath, System.Text.Encoding.UTF8);
            StreamWriter writer2 = new StreamWriter(fpath, false, System.Text.Encoding.UTF8);
            string SkanLine2;
            while ((SkanLine2 = sr2.ReadLine()) != null)
            {
                writer2.WriteLine(SkanLine2);
            }
            sr2.Close();
            writer2.Close();
        }
        
        //запись таймера в фаил
        public static void WriteTimer(int timer)
        {
            //открытие потока записи в фаил общего таймера
            StreamWriter writer = new StreamWriter(Global.path + @"base\timer.txt", false);
            //перезапись значения в фаил
            writer.WriteLine(timer);
            //закрытие потока
            writer.Close();
        }

        public static int CountTotal(int time)
        {
            //цена минуты
            int score;
            //сопоставление стоимости минуты
            if (time > 0)
            {
                if (time > 0 && time <= 60) score = 3;
                else if (time > 60 && time <= 120) score = 5;
                else if (time > 120 && time <= 180) score = 7;
                else score = 10;
            }
            else
            {
                score = 0;
            }
            return score;
        }

        //открытие рабочей формы
        public static void InfoShow()
        {
            if (!Global.infoShow)
            {
                //булевое отобрежия формы
                Global.infoShow = true;
                //сброс стартового таймера
                Global.bonustimer = 0;
                //создание формы инфо
                InfoForm IShow = new InfoForm();
                IShow.Show();
            }
        }

        //записывает строку истории сразу же в фаил
        public static void WriteHis(string text)
        {
            //указывает путь файла
            string NeedPath = @"his\" + Global.date + @".txt";
            //указывает полный путь к файлу
            string fpath = Global.path + NeedPath;
            //поток записи
            StreamWriter writer = new StreamWriter(fpath, true);
            //запись строки
            writer.WriteLine(text);
            //закрытие потока
            writer.Close();
        }        
    }

    class Retuning
    {

        //перезапись оценок
        public static void ReEvaCost(int Eva, string newCost)
        {
            string fpath = Global.path + @"base\eva.txt";
            //считывание с файла стоимости оценок
            StreamReader fread = new StreamReader(fpath);
            string[] SkanLine = new string[12];
            //записывает все стоимости в массив
            for (int i = 0; i < 12; i++)
            {
                SkanLine[i] = fread.ReadLine();
            }
            fread.Close();

            //меняет нужную стоимость на новую
            SkanLine[Eva - 1] = newCost;

            //перезаписывает в фаил
            StreamWriter fwrite = new StreamWriter(fpath, false);
            for (int i = 0; i < 12; i++)
            {
                fwrite.WriteLine(SkanLine[i]);
            }
            fwrite.Close();
        }
    }
}