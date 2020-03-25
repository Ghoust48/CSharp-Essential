using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    class Presenter
    {
        private Model _model;

        private Form1 _view;

        public Presenter(Form1 view)
        {
            _view = view;
            _model = new Model();

            _view.Started += Start;
            _view.Paused += Pause;
            _view.Stoped += Stop;

            _view.Timer1.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            _view.TextBoxTime.Text = _model.ShowTime();
        }

        private void Stop(object sender, EventArgs e)
        {
            _view.Timer1.Stop();
            _view.TextBoxTime.Clear();

            _model.Reset();
        }

        private void Pause(object sender, EventArgs e)
        {
            _view.Timer1.Enabled = false;
        }

        private void Start(object sender, EventArgs e)
        {
            _view.Timer1.Start();

            _view.Timer1.Enabled = true;
        }
    }
}
