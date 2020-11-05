using System;

namespace hw3es
{
    public abstract class Pupil
    {
        public abstract void Study();

        public abstract void Read();

        public abstract void Write();

        public abstract void Relax();
    }

    public class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Studies excellently");
        }

        public override void Read()
        {
            Console.WriteLine("Reads excellently");
        }

        public override void Write()
        {
            Console.WriteLine("Writes excellently");
        }

        public override void Relax()
        {
            Console.WriteLine("Relaxes no way");
        }
    }

    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Studies good");
        }

        public override void Read()
        {
            Console.WriteLine("Reads good");
        }

        public override void Write()
        {
            Console.WriteLine("Writes good");
        }

        public override void Relax()
        {
            Console.WriteLine("Relaxes bad");
        }
    }

    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Studies badly");
        }

        public override void Read()
        {
            Console.WriteLine("Reads badly");
        }

        public override void Write()
        {
            Console.WriteLine("Writes badly");
        }

        public override void Relax()
        {
            Console.WriteLine("Relaxes excellently");
        }
    }
}