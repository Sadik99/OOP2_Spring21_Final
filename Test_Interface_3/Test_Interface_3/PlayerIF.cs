using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    interface PlayerIF
    {
        void play(bool on);
        void Switch(bool on);
        void setVolume(int loudness);
    }
}
