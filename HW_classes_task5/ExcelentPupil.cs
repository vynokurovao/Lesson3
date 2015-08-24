using System;

namespace HW_classes_task5
{
    class ExcelentPupil : Pupil
    {
        public override void study()
        {
            Console.WriteLine("Excellent pupil: studying excellently");
        }

        public override void read()
        {
            Console.WriteLine("Excellent pupil: reading excellently");
        }

        public override void write()
        {
            Console.WriteLine("Excellent pupil: writing excellently");
        }

        public override void relax()
        {
            Console.WriteLine("Excellent pupil: relaxing excellently");
        }
    }
}
