using IronZip;
namespace IronZip.Examples.Overview.Quickstart
{
    public static class Section2
    {
        public static void Run()
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