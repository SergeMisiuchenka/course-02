using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];
        public ClassRoom (Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = p4;
        }

        public void Relax()
        {
            foreach (Pupil p in pupils)
            {
                p.Relax();
            }
        }
        public void Read()
        {
            foreach (Pupil p in pupils)
            {
                p.Read();
            }
        }
        public void Write()
        {
            foreach (Pupil p in pupils)
            {
                p.Write();
            }
        }
        public void Study()
        {
            foreach (Pupil p in pupils)
            {
                p.Study();
            }
        }
    }

}
