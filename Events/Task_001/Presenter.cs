using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_001
{
    class Presenter
    {
        private Form1 _view;

        private Model _model;

        public Presenter(Form1 view)
        {
            _model = new Model();
            _view = view;
            _view.Sum += Sum;
            _view.Sub += Sub;
            _view.Dirive += Dirive;
            _view.Multiply += Multiply;
        }

        private void Multiply(object sender, EventArgs e)
        {
            var result = _model.Multiply(_view.FirstNumber, _view.SecondNumber);
            _view.ShowResult(result.ToString());
        }

        private void Dirive(object sender, EventArgs e)
        {
            var result = _model.Dirive(_view.FirstNumber, _view.SecondNumber);
            _view.ShowResult(result.ToString());
        }

        private void Sub(object sender, EventArgs e)
        {
            var result = _model.Sub(_view.FirstNumber, _view.SecondNumber);
            _view.ShowResult(result.ToString());
        }

        private void Sum(object sender, EventArgs e)
        {
            var result = _model.Sum(_view.FirstNumber, _view.SecondNumber);
            _view.ShowResult(result.ToString());
        }
    }
}
