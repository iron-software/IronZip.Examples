using IronZip;
namespace ironzip.Quickstart
{
    public class Section4
    {
        public void Run()
        {
            // Open existing ZIP
            using (var archive = new IronZipArchive("existing.zip"))
            {
                // Add files
                archive.Add("./assets/image3.png");
                archive.Add("./assets/image4.png");
            
                // Export the ZIP file
                archive.SaveAs("result.zip");
            }
        }
    }
}