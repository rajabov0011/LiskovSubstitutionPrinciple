//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace LiskovSubstitutionPrinciple.Services
{
    internal class Document
    {
        private string? data { get; set; }
        private string? Filename { get; set; }
        private readonly string FilePath = "../../../Assets/Docs.txt";

        public Document(string data, string filename) 
        {
            this.data = data;
            this.Filename = filename;
            EnsureFileExists();
        }

        public void Open() =>
            this.data = File.ReadAllText(path: Filename);

        private void EnsureFileExists()
        {
            bool fileExists = File.Exists(FilePath);

            if (fileExists is false)
            {
                Console.WriteLine("File does not exists!");
            }
        }
    }
}