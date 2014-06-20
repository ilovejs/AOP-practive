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
using PostSharp.Patterns.Threading;

namespace Pluralsight.PostSharpV3.Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [Background]
        private void button1_Click(object sender, EventArgs e)
        {
            ThisProcessTakesALongTime();
            SignalFinished();
        }
        private void ThisProcessTakesALongTime()
        {
            Thread.Sleep(3000);
        }
        [Dispatched]
        private void SignalFinished()
        {
            textBox1.Text = "Done!";
        }
    }
}
