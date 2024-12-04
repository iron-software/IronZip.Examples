using IronZip;
using IronZip.Enum;

// Open protected ZIP
using (var archive = new IronZipArchive("existing.zip", "P@ssw0rd"))
{
    // Change to AES256-based encryption
    archive.Encrypt("P@ssw0rd", EncryptionMethods.AES256);
}
