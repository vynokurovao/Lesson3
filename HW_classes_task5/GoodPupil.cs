using System;

namespace HW_classes_task5
{
    class GoodPupil : Pupil
    {
        public override void study()
        {
            Console.WriteLine("Good pupil: studying good");
        }

        public override void read()
        {
            Console.WriteLine("Good pupil: reading good");
        }

        public override void write()
        {
            Console.WriteLine("Good pupil: writing good");
        }

        public override void relax()
        {
            Console.WriteLine("Good pupil: relaxing good");
        }
    }
}