namespace LibreriaDaTestare
{
    public class FileHelper
    {
        public int MyProperty { get; set; }

        public bool FileEsiste(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                throw new ArgumentNullException("filename");
            }
            return File.Exists(filename);   
        }
    }
}
