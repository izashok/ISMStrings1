using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibRED;
using LibSTR;


namespace FORM
{
    public partial class Form1 : Form
    {
        string s;
        string[] s1;
        string ss;
        string sss;
        bool q;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            bool q;
            LibSTR.Class1.Zero(ref s, out q);
            if (q == true)
            { label3.Text=("Все скобки закрыты"); }
            else
            { label3.Text=("Не все скобки закрыты"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ss;
            int z;
            LibSTR.Class1.One(ref s, out ss, out z);
            label3.Text=($"Самое долгое слово \"{ss}\" ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ss;
            int z;
            LibSTR.Class1.One(ref s, out ss, out z);
            label3.Text= ($"Количество слов \"{z}\"");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int z;
            LibSTR.Class1.Two(ref  s, out  z);
            label3.Text = ($"Количество разных слов \"{z}\"");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            LibSTR.Class1.Three(ref s, out s1);
            label3.Text = ("Слова с 2x буквами:");
            foreach (string x in s1)
            {
               label4.Text+=($"{x}\n");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LibSTR.Class1.Four(ref s, out ss);
            label3.Text=($"Ред. строка:\"{ss}\"");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LibSTR.Class1.Five(ref s,out ss);
            label3.Text= ($"Ред. строка:\"{ss}\"");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LibSTR.Class1.Six(ref s, out ss);
            label3.Text = ($"Ред. строка:\"{ss}\"");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Text =null;
            LibRED.Class1.ONE(ref s, out ss, out sss);
            label4.Text+=($"Номера Киевстар \n {ss}");
            label4.Text+=($"Номера Лайф \n {sss}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LibRED.Class1.TWO(ref s, out q);
            if (q == true)
                label3.Text = ("email правильный");
            else
                label3.Text = ("email неверный");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LibRED.Class1.THREE(ref s, out ss);
            label3.Text = ($"Правильные даты {ss}");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LibRED.Class1.FOUR(ref s, out ss);
            label3.Text = ($"Студаки {ss}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            LibRED.Class1.T1(ref s, out q);
            if (q == true)
                label3.Text = ("Время корректное");
            else
                label3.Text = ("Время некорректное");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            LibRED.Class1.T2(ref s, out q);
            if (q == true)
                label3.Text = ("Дата правильная");
            else
                label3.Text = ("Дата неправильная");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            LibRED.Class1.T3(ref s, out q);
            if (q == true)
                label3.Text = ("IP correct");
            else
                label3.Text = ("IP incorrect");
        }
    }
}
