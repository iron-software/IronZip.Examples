using IronZip;

// Create an empty GZIP
using (var archive = new IronGZipArchive())
{
    // Add a TAR file to the GZIP
    archive.Add("output.tar");

    // Export the GZIP file
    archive.SaveAs("output.tgz");
}
