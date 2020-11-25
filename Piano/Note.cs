using System;
using System.Collections.Generic;
using System.Text;

namespace Piano
{
    class Note
    {
        private int tone;
        private int dur;
        public int Tone
        {
            get
            {
                return tone;
            }
        }
        public int Dur
        {
            get
            {
                return dur;
            }
        }

        public Note (int Tone, int Duration)
        {
            tone = Tone;
            dur = Duration;
        }
    }
}
