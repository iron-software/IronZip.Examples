![Nuget](https://img.shields.io/nuget/v/IronZIP?color=informational&label=latest)
![Installs](https://img.shields.io/nuget/dt/IronZIP?color=informational&label=installs&logo=nuget)
![Passed](https://img.shields.io/badge/build-%20%E2%9C%93%20382%20tests%20passed%20(0%20failed)%20-107C10?logo=visualstudio)
![windows](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=windows)
![linux](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=linux&logoColor=white)
![macOS](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=apple)
![microsoftazure](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=microsoftazure)
![docker](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=docker&logoColor=white)
![aws](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=amazonaws)
[![livechat](https://img.shields.io/badge/Live%20Chat-8%20Engineers%20Active%20Today-purple?logo=googlechat&logoColor=white)](https://ironsoftware.com/csharp/zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield#helpscout-support)

## IronZIP - Compress and Decompress with Ease in C#

[![IronZIP NuGet Trial Banner Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronZIP-readme/nuget-trial-banner.png)](https://ironsoftware.com/csharp/zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topbanner#trial-license)

IronZIP simplifies the creation, modification, and saving of archive files in C# applications, thanks to the robust APIs provided by Iron Software.

#### Highlights of IronZIP:

  * Handles numerous archive formats: Images (jpg, png, gif, tiff, svg, bmp), Text, Documents (PDFs, DOCX, XLSX), Audio (MP3, WAV), and deeper ZIP archives.
  * Provides password protection options: Supports Traditional, AES128, and AES256 encryption.
  * Opens password-secured ZIP archives.
  * Unpacks ZIP, TAR, GZIP, and BZIP2 archive contents.
  * Offers 9 distinct compression levels.
  * Permits file additions to pre-existing archives.

Explore more on [our homepage](https://ironsoftware.com/csharp/zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist) including rich [code examples](https://ironsoftware.com/csharp/zip/examples/create-zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist) and a [comprehensive feature list](https://ironsoftware.com/csharp/zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist).

#### Cross-platform compatibility of IronZIP:

  * Versions: .NET 8, .NET 7, .NET 6, .NET 5, Core 2x & 3x, Standard 2, and Framework 4.6.2+
  * Operating Systems: Windows, macOS, Linux, as well as Docker, Azure, and AWS platforms

[![IronZIP Cross Platform Compatibility Support Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronZIP-readme/cross-platform-compatibility.png)](https://ironsoftware.com/csharp/zip/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=crossplatformbanner)

Discover our [comprehensive licensing details](https://ironsoftware.com/csharp/zip/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs) on our website.

### How to Utilize IronZIP

Installing the IronZIP NuGet package is streamlined:

```plaintext
PM> Install-Package IronZIP
```

After installation, introduce `IronZip;` at the beginning of your C# scripts. Below are some practical examples:

```csharp
using IronZip;

string file_path = "./archive.zip";
IronZipArchive.ExtractArchiveToDirectory(file_path, "unarchived"); // This will extract all files to the 'unarchived' directory

// Initiating a new ZIP archive
using (var archive = new IronZipArchive())
{
    // Adding files to the archive
    archive.Add("./assets/doc.pdf");
    archive.Add("./assets/img.png");

    // Saving the created ZIP archive
    archive.SaveAs("./output/archive.zip");
}
```

### Features Breakdown

##### Archive Creation

  * Media Types: Images (JPG, PNG, GIF, TIFF, SVG, BMP), Text files, and Documents (PDF, DOCX, XLSX)
  * Audio: MP3, WAV
  * Archive Types: ZIP, TAR, GZIP, BZIP2

##### Archive Extraction

  * Supported Formats: ZIP, TAR, GZIP, BZIP2

### Support and Licensing Options

For in-depth tutorials, code samples, and further documentation, head to <https://ironsoftware.com/csharp/zip/>

For queries, reach out to us at support@ironsoftware.com

### Documentation Resources

  * How-To Guides: [https://ironsoftware.com/csharp/zip/how-to/](https://ironsoftware.com/csharp/zip/how-to/license-keys/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Code Samples: [https://ironsoftware.com/csharp/zip/examples/](https://ironsoftware.com/csharp/zip/examples/create-zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Tutorials: [https://ironsoftware.com/csharp/zip/tutorials/](https://ironsoftware.com/csharp/zip/tutorials/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Licensing Information: [https://ironsoftware.com/csharp/zip/licensing/](https://ironsoftware.com/csharp/zip/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Live Chat Support: [https://ironsoftware.com/csharp/zip/#helpscout-support](https://ironsoftware.com/csharp/zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#helpscout-support)