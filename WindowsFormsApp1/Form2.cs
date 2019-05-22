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
        public string value;
        public Thread T3;
        public Form2()
        {
            InitializeComponent();
        }

        public void T3_Run()
        {

            Invoke(new Action(delegate ()
            {
                while (true)
                {
                    if (value != null)
                    {
                        float data = int.Parse(value, System.Globalization.NumberStyles.HexNumber) / 100.0f;
                        chart1.Series[0].Points.Add(data);
                        
                        Thread.Sleep(1000);
                    }
                }
            }));

        }

        public void Form2_Load(object sender, EventArgs e)
        {
            T3 = new Thread(new ThreadStart(T3_Run));
        }

        Form1 f1;
        private void Form2_ControlAdded(object sender, ControlEventArgs e)
        {
            chart1.Update();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1 = (Form1)this.Owner;
            f1.num = 0;
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1 = (Form1)this.Owner;
            f1.num = 0;
            f1.form2 = null;
        }
    }
}
