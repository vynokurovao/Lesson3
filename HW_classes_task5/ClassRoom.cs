using System;
using System.Collections.Generic;

namespace HW_classes_task5
{
    class ClassRoom
    {
        private List<Pupil> _pupils = new List<Pupil>();

        public List<Pupil> Pupils
        {
            get { return _pupils; }
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            _pupils.Add(pupil1);
            _pupils.Add(pupil2);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            _pupils.Add(pupil1);
            _pupils.Add(pupil2);
            _pupils.Add(pupil3);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            _pupils.Add(pupil1);
            _pupils.Add(pupil2);
            _pupils.Add(pupil3);
            _pupils.Add(pupil4);
        }
    }
}
