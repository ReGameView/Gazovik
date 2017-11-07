using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gazovik
{
    public partial class addStudents : Form
    {
        //Form1 MainForm = Form1;

        public SaveFileDialog SaveFileStudents = new SaveFileDialog();
        bool firstDate = true;
        DateTime today = new DateTime();
        string fileName1;

        public addStudents(string fileName)
        {
            fileName1 = fileName;
            InitializeComponent();
            monthCalendar1.ShowToday = false;
            today = monthCalendar1.TodayDate;
            monthCalendar1.MinDate = new DateTime(today.Year - 60, today.Month, today.Day);
            monthCalendar1.MaxDate = today;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            maskedTextBox1.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            if (firstDate)
            {
                maskedTextBox1.Text = monthCalendar1.TodayDate.ToString();
                firstDate = false;
            }
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '\\') || (e.KeyChar == '|')) e.Handled = true;
            else
                return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") ||
                (textBox1.Text == " ") || (textBox4.Text == " ") || (textBox5.Text == " ") ||
                (maskedTextBox1.Text == "") || (maskedTextBox2.Text == ""))
                MessageBox.Show("Введите все данные с форм");
            else
            {
                string data = textBox1.Text + " | " + maskedTextBox2.Text + " | " + maskedTextBox2.Text + " | " + textBox4.Text + " | " + textBox5.Text + " \\";
                string messages = "Вы добавили: " + textBox1.Text + " " + maskedTextBox2.Text + " " + maskedTextBox2.Text + " " + textBox4.Text + " " + textBox5.Text + ".";
                MessageBox.Show(messages);
                InsertStudent(data);
            }
        }

        public void InsertStudent(string data)
        { 
            SaveFileStudents.FileName = fileName1;
            //FIXME: Файл уже считывается в форме MainForm.
            //File.WriteAllText(SaveFileStudents.FileName, data);
            this.Close();
        }
    }
}
