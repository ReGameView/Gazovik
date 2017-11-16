using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;

namespace Gazovik
{
    public partial class updateStudents : Form
    {
        DateTime today = new DateTime();
        string[,] students = new string[10, 255];
        public updateStudents()
        {
            InitializeComponent();
            MySQLi sql = new MySQLi();
            SQLiteDataReader reader = sql.query("SELECT * FROM `students`");
            int i = 0;
            foreach(DbDataRecord record in reader)
            {
                students[0,i] = record["fio"].ToString();
                comboBox1.Items.Add(record["fio"].ToString());
                students[1, i] = record["b_day"].ToString();
                students[2, i] = record["mobile"].ToString();
                students[3, i] = record["address"].ToString();
                students[4, i] = record["fio_parent"].ToString();
                students[5, i] = record["fio_mobile"].ToString();
                i++;
            }
            /*try
            {
                today = monthCalendar1.TodayDate;
            }
            catch(NullReferenceException)
            {

            }
            /*monthCalendar1.MinDate = new DateTime(today.Year - 60, today.Month, today.Day);
            monthCalendar1.MaxDate = today;*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = comboBox1.SelectedItem.ToString();
            MessageBox.Show(i);
            //"Всё видимое видимо"
            int count = 0;
            while(true)
            {
                if (i == students[0, count])
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            /*.Text = students[0, i];
            maskedTextBox1.Text = students[1, i];
            maskedTextBox2.Text = students[2, i];
            textBox4.Text = students[3, i];
            textBox5.Text = students[4, i];*/
            label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; textBox1.Visible = true; maskedTextBox1.Visible = true; maskedTextBox2.Visible = true; textBox4.Visible = true; textBox5.Visible = true; button1.Visible = true;
            //textBox1.Text = students[comboBox1.SelectedItem,0];
            /*MessageBox.Show(i.ToString());*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
