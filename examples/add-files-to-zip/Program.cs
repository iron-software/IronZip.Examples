using IronZip;

// Open an existing ZIP
using (var archive = IronZipArchive.FromFile("existing.zip"))
{
    // Add files
    archive.Add("./assets/image3.png");
    archive.Add("./assets/image4.png");

    // Export the ZIP
    archive.SaveAs("result.zip");
}
