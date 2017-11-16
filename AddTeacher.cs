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
    public partial class AddTeacher : Form
    {
        MySQLi sql = new MySQLi();
        public AddTeacher()
        {     
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.query("INSERT INTO `teacher` VALUES(null,\"" + textBox1.Text + "\", \"" + textBox2.Text + "\")");
            this.Close();
        }
    }
}
