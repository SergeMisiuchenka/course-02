using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupilStudy");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupilRead");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupilWrite");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupilRelax");
        }
    }
}
