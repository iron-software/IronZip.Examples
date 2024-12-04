using IronZip;
namespace ironzip.CreateReadExtractZip
{
    public class Section2
    {
        public void Run()
        {
            // Extract ZIP
            IronZipArchive.ExtractArchiveToDirectory("output.zip", "extracted");
        }
    }
}