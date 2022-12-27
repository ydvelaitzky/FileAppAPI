namespace FileAppAPI.Entities
{
    public class FileModel
    {

        public int id { get; set; }
        public string fileName { get; set; }
        public fileType fileType { get; set; }
        public int fileSize { get; set; }//holds size in bytes.
        public string author { get; set; }
        public DateTime dateCreated { get; set; }
        public bool isEncoded { get; set; }
    }

    public enum fileType
    {
        PDF, Docx, xlsx, pptx, jpg
    }
}
