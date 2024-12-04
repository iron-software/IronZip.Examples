using IronZip;

// Create an empty TAR
using (var archive = new IronTarArchive())
{
    // Add files to the TAR
    archive.Add("./assets/image1.jpg");
    archive.Add("./assets/image2.jpg");
    archive.Add("./assets/image3.jpg");

    // Export the TAR
    archive.SaveAs("output.tar");
}
