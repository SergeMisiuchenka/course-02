using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupilStudy");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupilRead");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentPupilWrite");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentPupilRelax");
        }
    }
}
