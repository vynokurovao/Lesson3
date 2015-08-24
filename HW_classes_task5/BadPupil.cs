using System;

namespace HW_classes_task5
{
    class BadPupil : Pupil
    {
        public override void study()
        {
            Console.WriteLine("Bad pupil: studying bad");
        }

        public override void read()
        {
            Console.WriteLine("Bad pupil: reading bad");
        }

        public override void write()
        {
            Console.WriteLine("Bad pupil: writing bad");
        }

        public override void relax()
        {
            Console.WriteLine("Bad pupil: relaxing bad");
        }
    }
}