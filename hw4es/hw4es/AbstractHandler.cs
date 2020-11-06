using System;
using System.IO;
using System.Xml;

namespace hw4es
{
    public abstract class AbstractHandler
    {
        public string Filename { get; }
        public string Title { get; }
        public string Extension { get; }

        public AbstractHandler(string filename, string title, string extension)
        {
            Filename = filename;
            Extension = extension;
            Title = title;
        }

        public void Open()
        {
            Console.WriteLine($"Opening {Extension} file \"{Title}\"");
        }

        public void Create()
        {
            Console.WriteLine($"Creating {Extension} file \"{Title}\"");
        }

        public void Change()
        {
            Console.WriteLine($"Changing {Extension} file \"{Title}\"");
        }

        public abstract void Save();
    }

    public class XMLHandler : AbstractHandler
    {
        public XMLHandler(string filename, string title, string extension) : base(filename, title, extension)
        {
        }

        public override void Save()
        {
            Console.WriteLine("Saving XML " + Extension);
        }
    }

    public class TXTHandler : AbstractHandler
    {
        public TXTHandler(string filename, string title, string extension) : base(filename, title, extension)
        {
        }

        public override void Save()
        {
            Console.WriteLine("Saving TXT " + Extension);
        }
    }

    public class DOCHandler : AbstractHandler
    {
        public DOCHandler(string filename, string title, string extension) : base(filename, title, extension)
        {
        }

        public override void Save()
        {
            Console.WriteLine("Saving " + Extension);
        }
    }
}