//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace LiskovSubstitutionPrinciple.Services
{
    internal class Project
    {
        private List<Document> allDocs { get; set; }
        private List<WritableDocument> writableDocs { get; set; }

        public Project()
        {
            this.allDocs = new List<Document>();
            this.writableDocs = new List<WritableDocument>();
        }

        public void OpenAll()
        {
            foreach (Document document in this.allDocs)
            {
                document.Open();
            }
        }

        public void SaveAll()
        {
            foreach(WritableDocument document in this.writableDocs)
            {
                document.Save();
            }
        }
    }
}