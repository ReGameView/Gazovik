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
    public partial class Form1 : Form
    {
        public OpenFileDialog file = new OpenFileDialog();
        public StreamReader teacher, students;
        
        public bool OpenStudents = false;
        //Full array data students.
        public string[,] countStudents = new string[10,255];

        public string fileName;

        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        //Открыть файл учителя
        private void button1_Click(object sender, EventArgs e)
        {
            
            file.Filter = "Teacher Files|*.teacher";
            file.Title = "Select a Teacher File";

            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                teacher = new StreamReader(file.FileName);
                button1.Visible = false;
                button3.Visible = false;
                label1.Visible = true;
                label2.Text = teacher.ReadLine().ToString();
                label2.Visible = true;
                menuStrip1.Visible = true;
                добавитьУченикаToolStripMenuItem.Visible = false;
                удалитьУченикаToolStripMenuItem.Visible = false;
                изменитьДанныеУченикаToolStripMenuItem.Visible = false;
            }
        }

        //Освобождение файла (пока в релизе)
        private void button2_Click(object sender, EventArgs e)
        {
            file.Dispose();
            teacher.Dispose();
        }

        //Добавить учителя
        private void button3_Click(object sender, EventArgs e)
        {
            AddTeacher FormTeacher = new AddTeacher();
            FormTeacher.ShowDialog();
        }

        //Добавить ученика
        private void добавитьУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //students.Dispose();
            addStudents FormAddStudents = new addStudents(file.FileName);
            FormAddStudents.ShowDialog();
        }

        //Удалить ученика
        private void удалитьУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenStudents)
            {
                deleteStudents FormStudentsDelete = new deleteStudents(countStudents);
                FormStudentsDelete.ShowDialog();
            }
        }

        //Изменяем данные о учениках. Иницилизируем форму и посылаем ей переменную countStudents
        private void изменитьДанныеУченикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateStudents formUpdateStudents = new updateStudents(countStudents);
            formUpdateStudents.ShowDialog();
        }

        //Деффолтная, для отображения студентов. В будущем переделаю на моментальное отоброжение
        private void показатьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            добавитьУченикаToolStripMenuItem.Visible = true;
            удалитьУченикаToolStripMenuItem.Visible = true;
            изменитьДанныеУченикаToolStripMenuItem.Visible = true;
            file.Dispose();
            file.Filter = "Student Files|*.student";
            file.Title = "Select a Student File";
            //dataGridView1.Rows.Clear();
            // "Чёрный ящик"
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OpenStudents = true;
                label1.Visible = false;
                label2.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                dataGridView1.Visible = true;
                fileName = file.FileName;
                students = new StreamReader(fileName);
                string[] data;
                int count = 0;
                string line;
                int len = 0;    
                int j = 0;
                while (true)
                {
                    count = 0;
                    data = null;
                    data = new String[5];
                    line = students.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    len = line.Length;
                    for (int i = 0; i != len; i++)
                    {
                        if(!(line[i] == '\\'))
                        {
                            if (line[i] == '|')
                            {
                                count++;
                            }
                            else
                            {
                                data[count] += line[i];
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    dataGridView1.Rows.Add(data);
                    AddInCountStudents(data, j);
                    j++;
                }
            }
            показатьИнформациюToolStripMenuItem.Visible = false;  
        }

        //Заполняем переменную countStudents
        private void AddInCountStudents(string[] data, int j)
        {
            int count = 0;
            foreach(string element in data)
            {
                countStudents[count, j] = element;
                count++;
            }
        }
    }
}
