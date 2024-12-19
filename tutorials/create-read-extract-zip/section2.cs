using IronZip;
namespace IronZip.Examples.Tutorial.CreateReadExtractZip
{
    public static class Section2
    {
        public static void Run()
        {
            // Extract ZIP
            IronZipArchive.ExtractArchiveToDirectory("output.zip", "extracted");
        }
    }
}