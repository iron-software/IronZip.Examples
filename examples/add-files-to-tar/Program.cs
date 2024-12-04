using IronZip;

// Open existing TAR
using (var archive = IronTarArchive.FromFile("existing.tar"))
{
    // Add files
    archive.Add("./assets/image3.png");
    archive.Add("./assets/image4.png");

    // Export the TAR
    archive.SaveAs("result.tar");
}
