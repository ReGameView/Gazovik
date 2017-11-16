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
using System.Data.SQLite;
using System.Data.Common;

namespace Gazovik
{
    public partial class addStudents : Form
    {
        bool firstDate = true;
        DateTime today = new DateTime();

        public addStudents()
        {
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
                (maskedTextBox1.Text == "") || (maskedTextBox2.Text == "") ||
                (maskedTextBox3.Text == ""))
                MessageBox.Show("Введите все данные с форм");
            else
            {
                string[] data = new string[10];
                data[0] = textBox1.Text;
                data[1] = maskedTextBox1.Text;
                data[2] = maskedTextBox2.Text;
                data[3] = textBox4.Text;
                data[4] = textBox5.Text;
                data[5] = maskedTextBox3.Text;
                MySQLi sql = new MySQLi();
                string query = "INSERT INTO `students` VALUES(null, \"" + data[0] + "\", \"" + data[1] + "\", \"" + data[2] + "\", \"" + data[3] + "\", \"" + data[4] + "\", \"" + data[5] + "\");";
                sql.query(query);
                MessageBox.Show("Запись добавлена");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
