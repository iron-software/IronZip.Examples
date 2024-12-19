using IronZip;
namespace IronZip.Examples.Overview.Quickstart
{
    public static class Section3
    {
        public static void Run()
        {
            // Extract ZIP
            IronZipArchive.ExtractArchiveToDirectory("output.zip", "extracted");
        }
    }
}