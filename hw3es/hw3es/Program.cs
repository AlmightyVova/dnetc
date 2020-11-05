using System;

namespace hw3es
{
    class Program
    {
        static void Main()
        {
            #region MyRegion

            ClassRoom classRoom = new ClassRoom(
                new BadPupil(),
                new GoodPupil(),
                new GoodPupil(),
                new ExcellentPupil(),
                new BadPupil());

            classRoom.Show();

            #endregion

            #region Task 2

            var car = new Car("04ac14", 13.48, 144.15, 2000, 200, 2019);
            var plane = new Plane(2000, 150, 117.9, 165.8, 15000, 600, 2015);
            var ship = new Ship(300, "SP-OH-3i", 938.17, 88.3, 10000, 300, 2015);

            Console.WriteLine("Car:");
            car.Show();
            Console.WriteLine("\n".PadLeft(30, '='));

            Console.WriteLine("Plane:");
            plane.Show();
            Console.WriteLine("\n".PadLeft(30, '='));

            Console.WriteLine("Ship:");
            ship.Show();
            Console.WriteLine("\n".PadLeft(30, '='));

            #endregion

            #region Task 3

            var key = Console.ReadLine();

            var dw = new DocumentWorker();

            switch (key)
            {
                case ProDocumentWorker.AccessKey:
                    dw = new ProDocumentWorker();
                    break;
                case ExpertDocumentWorker.AccessKey:
                    dw = new ExpertDocumentWorker();
                    break;
            }
            
            dw.OpenDocument();
            dw.EditDocument();
            dw.SaveDocument();
            
            #endregion
        }
        
    }
}