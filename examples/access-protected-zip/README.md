> Full guide: [Access protected zip](https://ironsoftware.com/csharp/zip/examples/access-protected-zip/)

ZIP archives are a popular method for compressing several files into a single, shareable package. Occasionally, ZIP files containing confidential data might be accidentally sent to the wrong people. Thus, the ability to encrypt and decrypt files safely according to accepted security standards becomes crucial in ZIP utilities.

IronZIP encrypts and decrypts ZIP files. It supports several encryption methods, each reachable in a few lines of code.

```html
<div class="examples__featured-snippet">
    <h2>Decrypting and Encrypting Files with IronZIP</h2>
    <ol>
        <li>using IronZip;</li>
        <li>using IronZip.Enum;</li>
        <li>using (var archive = new IronZipArchive("protected.zip", "NewP@ss"))</li>
        <li>archive.Encrypt("NewP@ss", EncryptionMethods.AES256);</li>
    </ol>
</div>
```

### How to Access a Protected ZIP File

First, include the `IronZip` namespace in your project. Then, create an instance of `IronZipArchive` using two arguments: the location of the ZIP file and the password. If any details are incorrect, access to the file will be denied. Correct credentials will allow you to decrypt the ZIP, allowing you to view, alter, or extract its contents.

### Encrypt an Existing ZIP File

With the `IronZipArchive` class, not only can you access encrypted ZIPs, but you can also secure them using a choice of encryption methods. Begin by including the `IronZip.Enum` to utilize various encryption standards. Use the `Encrypt` function with a password and an encryption method to secure the file. `EncryptionMethods.AES256` is the strongest of the available options. Confirm your work by re-accessing the newly encrypted ZIP with the password. For details on available encryption options, visit [IronZip Enum EncryptionMethods documentation](https://ironsoftware.com/csharp/zip/object-reference/api/IronZip.Enum.EncryptionMethods.html).

[Creating, reading, and extracting ZIP files with IronZip](https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/)