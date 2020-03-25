using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_002
{
    public partial class Form1 : Form
    {
        public event EventHandler Started = null;
        public event EventHandler Paused = null;
        public event EventHandler Stoped = null;

        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
            InitializeTimer();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Started.Invoke(sender, e);
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            Paused.Invoke(sender, e);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Stoped.Invoke(sender, e);
        }

        private void InitializeTimer()
        {
            Timer1.Interval = 1000;
        }
    }
}
