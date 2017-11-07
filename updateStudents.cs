using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazovik
{
    public partial class updateStudents : Form
    {
        DateTime today = new DateTime();
        string[,] students = new string[10, 255];
        public updateStudents(string[,] students)
        {
            InitializeComponent();
            int count = 0;
            foreach (string element in students)
            {
                try
                {
                    comboBox1.Items.Add(element);
                    count++;
                }
                catch (System.NullReferenceException err)
                {
                    break;
                }
                catch (System.ArgumentNullException error)
                {
                    break;
                }
            }
                /*monthCalendar1.ShowToday = false;*/
                today = monthCalendar1.TodayDate;
                monthCalendar1.MinDate = new DateTime(today.Year - 60, today.Month, today.Day);
                monthCalendar1.MaxDate = today;
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            //"Всё видимое видимо"
            label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; textBox1.Visible = true; maskedTextBox1.Visible = true; maskedTextBox2.Visible = true; textBox4.Visible = true; textBox5.Visible = true; button1.Visible = true;
            //Не выводит данные, скорее всего индекс или массив пустой. Перепроверить.
            textBox1.Text = students[0,i];
            maskedTextBox1.Text = students[1, i];
            maskedTextBox2.Text = students[2, i];
            textBox4.Text = students[3, i];
            textBox5.Text = students[4, i];

            //textBox1.Text = students[comboBox1.SelectedItem,0];
            MessageBox.Show(i.ToString());
        }
    }
}
