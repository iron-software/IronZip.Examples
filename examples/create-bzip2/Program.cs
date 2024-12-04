using IronZip;

// Create an empty BZIP2
using (var archive = new IronBZip2Archive())
{
    // Add a text file to the BZIP2
    archive.Add("./assets/sample.txt");

    // Export the BZIP2 file
    archive.SaveAs("output.txt.bz2");
}
