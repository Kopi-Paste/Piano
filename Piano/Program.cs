using System;

namespace Piano
{
    class Program
    {
        static void Main(string[] args)
        {
            Note[] Ovcaci =
            {
                new Note((int)Tone.C1, (int)Duration.Quarter),
                new Note((int)Tone.E1, (int)Duration.Quarter),
                new Note((int)Tone.G1, (int)Duration.Quarter),
                new Note((int)Tone.C1, (int)Duration.Quarter),
                new Note((int)Tone.E1, (int)Duration.Quarter),
                new Note((int)Tone.G1, (int)Duration.Quarter),
                new Note((int)Tone.E1, (int)Duration.Eighth),
                new Note((int)Tone.E1, (int)Duration.Eighth),
                new Note((int)Tone.D1, (int)Duration.Eighth),
                new Note((int)Tone.E1, (int)Duration.Eighth),
                new Note((int)Tone.F1, (int)Duration.Eighth),
                new Note((int)Tone.D1, (int)Duration.Eighth),
                new Note((int)Tone.E1, (int)Duration.Eighth),
                new Note((int)Tone.E1, (int)Duration.Eighth),
                new Note((int)Tone.D1, (int)Duration.Eighth),
                new Note((int)Tone.E1, (int)Duration.Eighth),
                new Note((int)Tone.F1, (int)Duration.Eighth),
                new Note((int)Tone.D1, (int)Duration.Eighth),
                new Note((int)Tone.E1, (int)Duration.Quarter),
                new Note((int)Tone.D1, (int)Duration.Quarter),
                new Note((int)Tone.C1, (int)Duration.Quarter),
                
            };
            Play(Ovcaci);
            Play(Ovcaci);
            Console.ReadKey();
             
            

        }
        public enum Tone: int
        {
            Rest = 0,
            G0 = 196,
            A0 = 220,
            A0s = 233,
            B = 247,
            C1 = 262,
            C1s = 277,
            D1 = 294,
            D1s = 311,
            E1 = 330,
            F1 = 349,
            F1s = 370,
            G1 = 392,
            G1s = 415,
        }
        protected enum Duration
        {
        Whole = 1600,
        Half = Whole/2,
        Quarter = Whole/4,
        Eighth = Whole/8,
        Sixteenth = Whole/16,
        }
        public static void Play(Note[] song)
        {
            foreach (Note note in song)
            {
                Console.Beep(note.Tone, note.Dur);
            }
        }
    }
}
