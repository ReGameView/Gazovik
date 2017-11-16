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
    public partial class deleteStudents : Form
    {
        MySQLi sql = new MySQLi();
        SQLiteDataReader reader;
        public deleteStudents()
        {
            
            reader = sql.query("SELECT `fio` FROM `students`");
            InitializeComponent();
            foreach (DbDataRecord record in reader)
            {
                comboBox1.Items.Add(record["fio"]);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM `students` WHERE `id` = " + (comboBox1.SelectedIndex + 1);
                //MessageBox.Show(query);
                reader = sql.query(query);
                MessageBox.Show("Запись успешно удалена!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("null");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
