namespace hw4es
{
    public class Manipulator
    {
        public AbstractHandler Handler { get; }

        public Manipulator(string filename)
        {
            string extension = filename.Substring(filename.LastIndexOf('.'));
            string title = filename.Substring(0, filename.Length - extension.Length);
            Handler = extension switch
            {
                ".xml" => new XMLHandler(filename, title, extension),
                ".txt" => new TXTHandler(filename, title, extension),
                ".doc" => new DOCHandler(filename, title, extension),
                _ => Handler
            };
        }
    }
}