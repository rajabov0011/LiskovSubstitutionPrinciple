//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace LiskovSubstitutionPrinciple.Services
{
    internal class WritableDocument : Document
    {
        private readonly string FILEPATH = "../../../Assets/Docs.txt";
        private string Data { get; set; }
        public string FileName { get; set; }

        public WritableDocument(string data, string filename) : base(data, filename)
        {
            this.Data = data;
            this.FileName = filename;
        }

        public void Save()
        {
            File.WriteAllText(this.Data, this.FileName);
            Console.WriteLine("Document saved successfully!");
        }
    }
}