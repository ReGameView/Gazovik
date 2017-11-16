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
    public partial class settings : Form
    {
        IniFile INI = new IniFile("config.ini");
        string[,] data = new string[255, 255];

        public settings()
        {
            InitializeComponent();
            auto_read();
        }

        private void auto_read()
        {
            if(INI.KeyExists("Name", "DataBase"))
            {
                data[1, 1] = INI.ReadINI("DataBase", "Name");
                textBox1.Text = data[1, 1];
            }
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != data[1,1])
            {
                INI.Write("DataBase", "Name", textBox1.Text);
            }
            button2.Enabled = false;
            //MessageBox.Show("Изменения сохранены!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            this.Close();
        }
    }
}
