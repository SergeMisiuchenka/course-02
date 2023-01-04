using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupilStudy");
        }
        public override void Read()
        {
            Console.WriteLine("GoodPupilRead");
        }
        public override void Write()
        {
            Console.WriteLine("GoodPupilWrite");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodPupilRelax");
        }
    }
}
