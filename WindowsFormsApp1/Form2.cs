using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 f1;
        private void Form2_ControlAdded(object sender, ControlEventArgs e)
        {
            chart1.Update();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1 = (Form1)this.Owner;
            f1.num = 987654321;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1 = (Form1)this.Owner;
            f1.num = 987654321;
        }
    }
}
