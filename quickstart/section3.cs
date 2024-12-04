using IronZip;
namespace ironzip.Quickstart
{
    public class Section3
    {
        public void Run()
        {
            // Extract ZIP
            IronZipArchive.ExtractArchiveToDirectory("output.zip", "extracted");
        }
    }
}