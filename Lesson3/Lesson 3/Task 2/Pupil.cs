using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Study");
        }
        public virtual void Read()
        {
            Console.WriteLine("Read");
        }
        public virtual void Write()
        {
            Console.WriteLine("Write");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Relax");
        }

    }

}
