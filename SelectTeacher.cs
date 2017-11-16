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
    public partial class SelectTeacher : Form
    {
        MySQLi sql = new MySQLi();
        SQLiteDataReader reader = null;
        string teacher;

        public SelectTeacher()
        {
            InitializeComponent();
            reader = sql.query("SELECT * FROM teacher");
            foreach(DbDataRecord record in reader)
            {
                comboBox1.Items.Add(record["fio"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = false;
            string name = null;
            reader.Close();
            try
            {
                name = comboBox1.SelectedItem.ToString();
            }
            catch(NullReferenceException)
            {
                error = true;
                MessageBox.Show("Выберите учителя");
            }
            error = true;
            bool readernull = false;
            try
            {
                string query = "SELECT `pass` FROM `teacher` WHERE `fio` = \"" + name + "\";";
                //MessageBox.Show(query);
                reader = sql.query(query);
                if (!readernull)
                {
                    foreach(DbDataRecord record in reader)
                    {
                        if(record["pass"].ToString() == textBox2.Text)
                        {
                            error = false;
                        }
                        else
                        {
                            MessageBox.Show("Пароль введён не верно");
                        }
                    }
                }
            }
            catch(NullReferenceException er)
            {
                readernull = true;
                MessageBox.Show("ERROR Query in DB: " + er);
            }
//            MessageBox.Show(reader.GetString(0));
            if (!error)
            {
                Form1 frm = new Form1();
                MessageBox.Show("Добро пожаловать " + name);
                teacher = textBox2.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        public string returnData()
        {
            return teacher;
        }
    }
}
