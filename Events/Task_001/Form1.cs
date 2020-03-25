using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_001
{
    public partial class Form1 : Form
    {
        public event EventHandler Sum;
        public event EventHandler Dirive;
        public event EventHandler Multiply;
        public event EventHandler Sub;

        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public void ShowResult(string value)
        {
            ResultText.Text = value;
        }

        private void InitializeNumbers()
        {
            FirstNumber = int.Parse(FirstNumText.Text);
            SecondNumber = int.Parse(SecondNumText.Text);
        }

        private void SumButtonClick(object sender, EventArgs e)
        {
            InitializeNumbers();
            Sum.Invoke(sender, e);
        }

        private void SubButtonClick(object sender, EventArgs e)
        {
            InitializeNumbers();
            Sub.Invoke(sender, e);
        }

        private void MultiplyButtonClick(object sender, EventArgs e)
        {
            InitializeNumbers();
            Multiply.Invoke(sender, e);
        }

        private void DiriveButtonClick(object sender, EventArgs e)
        {
            InitializeNumbers();
            Dirive.Invoke(sender, e);
        }
    }
}
