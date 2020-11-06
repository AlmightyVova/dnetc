using System;

namespace hw4es
{
    class Program
    {
        static void Main()
        {
            #region Task 2

            Manipulator manipulator = new Manipulator("Файлик.xml");
            
            Console.WriteLine($"Filename is: {manipulator.Handler.Filename}");
            Console.WriteLine($"Extension is: {manipulator.Handler.Extension}");
            Console.WriteLine($"Title is: {manipulator.Handler.Title}");
            
            manipulator.Handler.Change();
            manipulator.Handler.Create();
            manipulator.Handler.Open();
            manipulator.Handler.Save();

            Console.WriteLine("\n".PadLeft(30,'='));
            
            manipulator = new Manipulator("Файлик.txt");
            
            Console.WriteLine($"Filename is: {manipulator.Handler.Filename}");
            Console.WriteLine($"Extension is: {manipulator.Handler.Extension}");
            Console.WriteLine($"Title is: {manipulator.Handler.Title}");
            
            manipulator.Handler.Change();
            manipulator.Handler.Create();
            manipulator.Handler.Open();
            manipulator.Handler.Save();
            
            Console.WriteLine("\n".PadLeft(30,'='));
            
            manipulator = new Manipulator("Файлик.doc");
            
            Console.WriteLine($"Filename is: {manipulator.Handler.Filename}");
            Console.WriteLine($"Extension is: {manipulator.Handler.Extension}");
            Console.WriteLine($"Title is: {manipulator.Handler.Title}");
            
            manipulator.Handler.Change();
            manipulator.Handler.Create();
            manipulator.Handler.Open();
            manipulator.Handler.Save();

            #endregion

            #region Task 3

            Player player = new Player();
            player.Play();

            #endregion
        }
    }
}