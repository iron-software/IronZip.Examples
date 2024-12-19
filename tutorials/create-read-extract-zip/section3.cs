using IronZip;
namespace IronZip.Examples.Tutorial.CreateReadExtractZip
{
    public static class Section3
    {
        public static void Run()
        {
            // Open existing ZIP
            using (var archive = IronZipArchive.FromFile("existing.zip"))
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