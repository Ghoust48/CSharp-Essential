using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    class Model
    {
        private int _sec;
        private int _min;

        public string ShowTime()
        {
            _sec++;

            if (_sec > 59)
            {
                _min++;
                _sec = 0;
            }

            return $"Прошло: {_min} минут {_sec} секунд";
        }

        public void Reset()
        {
            _sec = 0;
            _min = 0;
        }
    }
}
