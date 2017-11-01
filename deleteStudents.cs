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
    public partial class deleteStudents : Form
    {
        string[,] students = new String[5,255];
        public deleteStudents()
        {
            InitializeComponent();
            /*foreach (var item in students)
            {
                comboBox1.Items.Add("1");
            }*/
            
        }
    }
}
