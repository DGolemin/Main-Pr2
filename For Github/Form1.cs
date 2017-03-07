using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace For_Github
{
    public partial class Form1 : Form
    {
        Int32 save = 0;
        String name;
        String time;
        Int32 timeS=0;
        Int32 timeSX = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process p = new System.Diagnostics.Process();  // для открытия внешней программы
            // команды, необходимые для доступа к другому приложению. изменить только путь
            p.StartInfo.FileName = "saveGit.exe"; // имя атакуемого файла
               // перехватывает поток ввода в программу-взломщик
            p.Start(); 			        // запускает программу

            save++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader Joric34 = new StreamReader("Gittime.txt");
           Int32 a2 = Convert.ToInt32(Joric34.ReadLine());
            Joric34.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StreamReader Joric22 = new StreamReader("saveGitName.txt");
            name = Joric22.ReadLine();
            Joric22.Close();
            label1.Text="Имя: "+name+" Кол-во сохранений: "+save+" Время: "+DateTime.Now;
            StreamReader Joric24 = new StreamReader("Gittime.txt");
            time = Joric24.ReadLine();
            Joric24.Close();
            checkBox1.Text = "Сохранять каждые "+time+" минут.Осталось "+timeS+":"+timeSX;
            if(checkBox1.Checked==true)
            {
                if (timeS == 0 && timeSX==0)
                {
                    System.Diagnostics.Process p = new System.Diagnostics.Process();  // для открытия внешней программы
                    // команды, необходимые для доступа к другому приложению. изменить только путь
                    p.StartInfo.FileName = "saveGit.exe"; // имя атакуемого файла
                    // перехватывает поток ввода в программу-взломщик
                    p.Start(); 			        // запускает программу

                    save++;
                    timeS = Convert.ToInt32(time);
                    timeSX = 0;
                }
                else 
                {
                    
                    if(timeSX==0)
                    {
                        timeS--;
                        timeSX = 60;
                    }
                    timeSX--;
                }


            }
        }
    }
}
