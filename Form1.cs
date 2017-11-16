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
    public partial class Form1 : Form
    {

        private string[,] dataTeacher = new string[5, 5];
        IniFile INI = new IniFile("config.ini");
        public string DataBasesName;
        public bool OpenStudents = false;
        public string[,] countStudents = new string[10,255];

        public string fileName;

        public Form1()
        {
            InitializeComponent();
            auto_read();
        }

        public void OK_selected_teacher()
        {
            ученикиToolStripMenuItem.Visible = true;
            добавитьУченикаToolStripMenuItem.Visible = true;
            удалитьУченикаToolStripMenuItem.Visible = true;
            изменитьДанныеУченикаToolStripMenuItem.Visible = true;
            OpenStudents = true;
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            dataGridView1.Visible = true;
        }

        private void auto_read()
        {
            if (INI.KeyExists("Name", "DataBase"))
                DataBasesName = INI.ReadINI("DataBase", "Name");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectTeacher FormSelectTeacher = new SelectTeacher();
            FormSelectTeacher.ShowDialog();

            if(FormSelectTeacher.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(FormSelectTeacher.returnData());
                OK_selected_teacher();
            }
            addRowsFromDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddTeacher FormTeacher = new AddTeacher();
            FormTeacher.ShowDialog();
        }

        private void добавитьУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addStudents FormAddStudents = new addStudents();
            FormAddStudents.ShowDialog();
            if (FormAddStudents.DialogResult == DialogResult.OK)
            {
                updateData();
            }
        }

        private void удалитьУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenStudents)
            {
                deleteStudents FormStudentsDelete = new deleteStudents();
                FormStudentsDelete.ShowDialog();
                if (FormStudentsDelete.DialogResult == DialogResult.OK)
                {
                    updateData();
                }
            }
        }

        private void изменитьДанныеУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateStudents formUpdateStudents = new updateStudents();
            formUpdateStudents.ShowDialog();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings FormSettings = new settings();
            FormSettings.ShowDialog();
        }

        public void updateData()
        {
            int rowsCount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            }
            addRowsFromDB();
        }

        private void addRowsFromDB()
        {
            MySQLi sql = new MySQLi();
            SQLiteDataReader reader = sql.query("SELECT * FROM `students`");
            string[] data = new string[10];
            foreach (DbDataRecord record in reader)
            {
                data[0] = record["fio"].ToString();
                data[1] = record["b_day"].ToString();
                data[2] = record["mobile"].ToString();
                data[3] = record["address"].ToString();
                data[4] = record["fio_parent"].ToString();
                data[5] = record["fio_mobile"].ToString();
                dataGridView1.Rows.Add(data);
            }
        }
    }
}
