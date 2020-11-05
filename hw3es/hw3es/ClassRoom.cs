using System;
using System.Collections.Generic;

namespace hw3es
{
    public class ClassRoom
    {
        Pupil[] Pupils{ get; }
        public ClassRoom(params Pupil[] pupils)
        {
            Pupils = pupils;
        }

        public void Show()
        {
            foreach (var pupil in Pupils)
            {
                Console.WriteLine("This pupil:");
                pupil.Read();
                pupil.Relax();
                pupil.Study();
                pupil.Write();
                Console.WriteLine("\n".PadLeft(30, '='));
            }
        }
    }
}