![Nuget](https://img.shields.io/nuget/v/IronZIP?color=informational&label=latest)![Installs](https://img.shields.io/nuget/dt/IronZIP?color=informational&label=installs&logo=nuget)![Passed](https://img.shields.io/badge/build-%20%E2%9C%93%20382%20tests%20passed%20(0%20failed)%20-107C10?logo=visualstudio)![windows](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=windows)![linux](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=linux&logoColor=white)![macOS](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=apple)![microsoftazure](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=microsoftazure)![docker](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=docker&logoColor=white)![aws](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=amazonaws)[![livechat](https://img.shields.io/badge/Live%20Chat-8%20Engineers%20Active%20Today-purple?logo=googlechat&logoColor=white)](https://ironsoftware.com/csharp/zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield#helpscout-support)

## IronZIP - The Comprehensive C# Library for ZIP Archives

[![IronZIP NuGet Trial Banner Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronZIP-readme/nuget-trial-banner.png)](https://ironsoftware.com/csharp/zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topbanner#trial-license)

IronZIP is a robust library offered by Iron Software, designed specifically for C# developers to manage ZIP archives efficiently and effectively.

#### IronZIP Highlights:

  * Supports a variety of file types for archiving including Images (jpg, png, gif, tiff, svg, bmp), Text Files, Documents (PDF, DOCX, XLSX), Audio (MP3, WAV), and even nested ZIP files.
  * Offers robust encryption for securing archives: Supports Traditional, AES128, and AES256 standards.
  * Enables access to password-protected ZIP archives.
  * Facilitates the extraction of contents from ZIP, TAR, GZIP, and BZIP2 formats.
  * Provides 9 choices for compression levels.
  * Allows addition of files to existing archives.

Explore more by visiting [our website](https://ironsoftware.com/csharp/zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist) for a comprehensive [list of our features](https://ironsoftware.com/csharp/zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist) and useful [code examples](https://ironsoftware.com/csharp/zip/examples/create-zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist).

#### IronZIP is compatible across various platforms:

  * Compatibility ranges across .NET versions including .NET 8, .NET 7, .NET 6, and .NET 5, Core 2x & 3x, Standard 2, and Framework 4.6.2+
  * Runs on Windows, macOS, Linux, and is deployable on Docker, Azure, and AWS

[![IronZIP Cross Platform Compatibility Support Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronZIP-readme/cross-platform-compatibility.png)](https://ironsoftware.com/csharp/zip/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=crossplatformbanner)

Our detailed [licensing information](https://ironsoftware.com/csharp/zip/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs) is readily available online.

### How to Use IronZIP

Simply install the IronZIP NuGet package by running:

    PM> Install-Package IronZIP
    

After installation, include `using IronZip;` at the beginning of your C# files. Here are some example uses:

    using IronZip;
    
    // Specify the file path
    string file_path = "./archive.zip";
    // Extract contents of the archive to a new directory named 'unarchived'
    IronZipArchive.ExtractArchiveToDirectory(file_path, "unarchived"); 
    
    // Create and manipulate a new ZIP archive
    using (var archive = new IronZipArchive())
    {
        // Adding files to the archive
        archive.Add("./assets/doc.pdf");
        archive.Add("./assets/img.png");
    
        // Save the archive to a file
        archive.SaveAs("./output/archive.zip");
    }
    

### Comprehensive Features List

##### Archive Creation

  * Supported formats include Images (JPG, PNG, GIF, TIFF, SVG, BMP), Text files, and various Document and Audio formats.

##### Archive Access

  * Open ZIP, TAR, GZIP, and BZIP2 archives.

##### Archive Export

  * Ability to export to ZIP, TAR, GZIP, and BZIP2 formats.

### Licensing & Customer Support

For in-depth tutorials, sample code, and documentation, please visit [https://ironsoftware.com/csharp/zip/](https://ironsoftware.com/csharp/zip/)

Reach out to our support team via support@ironsoftware.com

### Helpful Documentation Links

  * How-To Guides : [https://ironsoftware.com/csharp/zip/how-to/](https://ironsoftware.com/csharp/zip/how-to/license-keys/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Example Codes : [https://ironsoftware.com/csharp/zip/examples/](https://ironsoftware.com/csharp/zip/examples/create-zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Tutorials : [https://ironsoftware.com/csharp/zip/tutorials/](https://ironsoftware.com/csharp/zip/tutorials/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Licensing Details : [https://ironsoftware.com/csharp/zip/licensing/](https://ironsoftware.com/csharp/zip/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Live Chat Assistance : [https://ironsoftware.com/csharp/zip/#helpscout-support](https://ironsoftware.com/csharp/zip/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#helpscout-support)