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
        //string[,] students = new String[5,255];
        public deleteStudents(string[,] students)
        {
            InitializeComponent();
            int count = 0;
            foreach (var item in students)
            {
                try
                {
                    comboBox1.Items.Add(item);
                }
                catch (System.NullReferenceException err)
                {
                    break;
                }catch(System.ArgumentNullException error)
                {
                    break;
                }
                count++;
            }
            
        }
    }
}
