using IronZip;

// Create an empty ZIP
using (var archive = new IronZipArchive())
{
    // Add files to the ZIP
    archive.Add("./assets/image1.jpg");
    archive.Add("./assets/image2.jpg");
    archive.Add("./assets/image3.jpg");

    // Export the ZIP
    archive.SaveAs("output.zip");
}
