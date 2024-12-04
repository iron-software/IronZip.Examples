using IronZip;
using IronZip.Enum;

// Create empty ZIP with highest compression
using (var archive = new IronZipArchive(9))
{
    // Password protect the ZIP (Support AES128 & AES256)
    archive.Encrypt("P@ssw0rd", EncryptionMethods.Traditional);

    archive.Add("./assets/image1.jpg");
    archive.Add("./assets/image2.jpg");

    // Export the ZIP
    archive.SaveAs("output.zip");
}
