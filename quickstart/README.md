# Getting Started with IronZIP

> Docs: [IronZip documentation](https://ironsoftware.com/csharp/zip/docs/?utm_source=github)


## IronZIP: Your Comprehensive Archive Solution for .NET

**IronZIP** stands as an archive compression and decompression tool from Iron Software, supporting formats such as ZIP, TAR, GZIP, and BZIP2.

### Comprehensive C# Library for Managing Archives

1. [Acquire the C# library for file compression and decompression here](https://www.nuget.org/packages/IronZip/)
2. Manage ZIP, TAR, GZIP, and BZIP2 formats efficiently
3. Adjustable compression levels ranging from 0 to 9
4. Retrieve contents from compressed files
5. Add files to pre-existing ZIP archives or create entirely new ones

### Compatibility Details

**IronZIP** offers extensive compatibility across various platforms:

#### .NET Version Compatibility:

- **C#**, **VB.NET**, **F#**
- **.NET 7, 6**, 5, and Core 3.1+
- .NET Standard (2.0+)
- .NET Framework (4.6.2+)

#### Supported Operating Systems and Environments:

- **Windows** (10+, Server 2016+)
- **Linux** (Ubuntu, Debian, CentOS, etc.)
- **macOS** (10+)
- **iOS** (12+)
- **Android** API 21+ (v5 "Lollipop")
- **Docker** (Windows, Linux, Azure)
- **Azure** (VPS, WebApp, Function)
- **AWS** (EC2, Lambda)

#### .NET Project Compatibility:

- **Web** (Blazor & WebForms)
- **Mobile** (Xamarin & MAUI)
- **Desktop** (WPF & MAUI)
- **Console** (Applications & Libraries)

## Installation Guide

### Setting Up IronZIP

To integrate IronZIP into your project, enter the following command in your CLI or package manager console:

```shell
Install-Package IronZip
```

You can also download it directly from the [official IronZIP NuGet page](https://www.nuget.org/packages/IronZip).

After installation, initiate your C# projects by incorporating `using IronZip;` at the beginning of your code.

## License Activation

To activate IronZIP, you need to provide a valid license or trial key. Insert this line in your code after the 'using' directive, before invoking any IronZIP functionalities:

```csharp
using IronZip;

// Insert your license key below
IronZip.License.LicenseKey = "YOUR_LICENSE_KEY";
```

## Practical Coding Examples

### How to Create a ZIP Archive

Here's how to construct a ZIP file using the `AddArchiveEntry` and `SaveAs` methods within a `using` block.

```csharp
using IronZip;

class Program
{
    static void Main()
    {
        // Create a new ZIP file instance
        using (var archive = new IronZipArchive())
        {
            // Adding a file to the ZIP
            archive.Add("path/to/example.txt");

            // Finalize and save the ZIP file
            archive.SaveAs("archive.zip");
        }
    }
}
```

### Unzip Archive to a Directory

To extract files from a ZIP to a specified directory, utilize the `ExtractArchiveToDirectory` method.

```csharp
using IronZip;

class Program
{
    static void Main()
    {
        // Define the ZIP and extraction paths
        string zipPath = "archive.zip";
        string extractPath = "extracted/";

        // Perform extraction
        // ExtractArchiveToDirectory is a static method on IronZipArchive
        IronZipArchive.ExtractArchiveToDirectory(zipPath, extractPath);
    }
}
```

### Adding Files to an Existing ZIP Archive

To add more files to an already existing ZIP archive, use the `AddArchiveEntry` method again and save the changes.

```csharp
using IronZip;

class Program
{
    static void Main()
    {
        // Accessing an existing ZIP file
        using (var archive = new IronZipArchive("archive.zip"))
        {
            // Append another file
            archive.Add("path/to/anotherfile.txt");

            // Commit changes to the same ZIP file
            archive.SaveAs("archive.zip");
        }
    }
}
```

## Licenses and Support Services

**IronZIP** requires a purchase, but you can start with a free trial by acquiring a license [here](https://ironsoftware.com/csharp/zip/?utm_source=github#trial-license).

For detailed information about Iron Software, explore our [homepage](https://ironsoftware.com/?utm_source=github).
For further assistance and questions, [contact our expert team](https://ironsoftware.com/?utm_source=github#live-chat-support).

### Customer Assistance from Iron Software

For all kinds of support and technical queries, reach out to us via email at: <support@ironsoftware.com>