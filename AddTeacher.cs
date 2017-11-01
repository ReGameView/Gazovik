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
    public partial class AddTeacher : Form
    {
        public SaveFileDialog file = new SaveFileDialog();

        public AddTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            file.Filter = "Teacher Files|*.teacher";
            file.Title = "Save a Teacher File";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = file.FileName;
                File.WriteAllText(fileName, textBox1.Text);
            }
        }
    }
}
