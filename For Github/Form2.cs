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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader Joric = new StreamReader("Gittime.txt");
            textBox1.Text = Joric.ReadLine();
            Joric.Close();
            StreamReader Joric1 = new StreamReader("saveGitSite.txt");
            textBox2.Text = Joric1.ReadLine();
            Joric1.Close();
            StreamReader Joric2 = new StreamReader("saveGitName.txt");
            textBox3.Text = Joric2.ReadLine();
            Joric2.Close();
            StreamReader Joric3 = new StreamReader("saveGitexe.txt");
            textBox4.Text = Joric3.ReadLine();
            Joric3.Close();
            StreamReader Joric4 = new StreamReader("saveGit.txt");
            textBox5.Text = Joric4.ReadLine();
            Joric4.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Fota = new StreamWriter("Gittime.txt");
            Fota.WriteLine(textBox1.Text);
            Fota.Close();
            StreamWriter Fota1 = new StreamWriter("saveGitSite.txt");
            Fota1.WriteLine(textBox2.Text);
            Fota1.Close();
            StreamWriter Fota2 = new StreamWriter("saveGitName.txt");
            Fota2.WriteLine(textBox3.Text);
            Fota2.Close();
            StreamWriter Fota3 = new StreamWriter("saveGitexe.txt");
            Fota3.WriteLine(textBox4.Text);
            Fota3.Close();
            StreamWriter Fota4 = new StreamWriter("saveGit.txt");

       


            Fota4.WriteLine(textBox5.Text);
            Fota4.Close();
        }
    }
}
