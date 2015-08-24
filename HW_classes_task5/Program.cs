using System;

namespace HW_classes_task5
{
    class Program
    {
        public static void DisplayInformation(ClassRoom classRoom)
        {
            Console.WriteLine("This is new classroom");
            foreach (Pupil pupil in classRoom.Pupils)
            {
                pupil.study();
                pupil.read();
                pupil.write();
                pupil.relax();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ExcelentPupil excellentPupil = new ExcelentPupil();
            GoodPupil goodPupil = new GoodPupil();
            BadPupil badPupil1 = new BadPupil();
            BadPupil badPupil2 = new BadPupil();
            ClassRoom classRoom1 = new ClassRoom(excellentPupil, goodPupil);
            ClassRoom classRoom2 = new ClassRoom(excellentPupil, goodPupil, badPupil1);
            ClassRoom classRoom3 = new ClassRoom(excellentPupil, goodPupil, badPupil1, badPupil2);

            DisplayInformation(classRoom1);
            DisplayInformation(classRoom2);
            DisplayInformation(classRoom3);

            Console.ReadKey();        
        }
    }
}
