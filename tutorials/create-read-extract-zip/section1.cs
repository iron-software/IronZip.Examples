using IronZip;
namespace ironzip.CreateReadExtractZip
{
    public class Section1
    {
        public void Run()
        {
            // Create an empty ZIP
            using (var archive = new IronZipArchive())
            {
                // Add files to the ZIP
                archive.Add("./assets/image1.png");
                archive.Add("./assets/image2.png");
            
                // Export the ZIP file
                archive.SaveAs("output.zip");
            }
        }
    }
}