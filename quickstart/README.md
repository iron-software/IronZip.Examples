# Getting Started with IronZIP

***Based on <https://ironsoftware.com/docs/docs/>***


## IronZIP: Your Comprehensive Archiving Solution for .NET

**IronZIP** stands as a comprehensive library by Iron Software, enabling not only ZIP but also TAR, GZIP, and BZIP2 file formats for both compression and decompression. 

### Compatibility

**IronZIP** is universally compatible across a variety of platforms and environments:

#### Supported .NET Versions:

- **C#**, **VB.NET**, **F#**
- **.NET 7, 6**, 5, and Core 3.1+
- .NET Standard (2.0+)
- .NET Framework (4.6.2+)

#### Supported Operating Systems and Environments:

- **Windows** (10+, Server 2016+)
- **Linux** (Ubuntu, Debian, CentOS, etc.)
- **macOS** (10+)
- **iOS** (12+)
- **Android** API 21+ (v5 “Lollipop”)
- **Docker** (Windows, Linux, Azure)
- **Azure** (VPS, WebApp, Function)
- **AWS** (EC2, Lambda)

#### Supported .NET Project Types:

- **Web** (Blazor & WebForms)
- **Mobile** (Xamarin & MAUI)
- **Desktop** (WPF & MAUI)
- **Console** (App & Library)

## Installation

### IronZIP Library

To install the IronZIP library, simply run the following command:

```shell
Install-Package IronZip
```

Or directly download it from the [IronZIP official NuGet page](https://www.nuget.org/packages/IronZip).

After installation, insert `using IronZip;` at the beginning of your C# files to start utilizing IronZIP functionalities.

## Applying a License Key

To unlock full features of IronZIP, key in a valid license or trial key as shown below, right after your using statements and before calling any IronZIP methods:

```cs
IronZip.License.LicenseKey = "IRONZIP.MYLICENSE.KEY.1EF01";
```

## Code Examples

## Creating a ZIP Archive

Here's how you can create a new ZIP file. Within a 'using' statement, use `AddArchiveEntry` to add files and `SaveAs` to write the ZIP file to disk.

```cs
using IronZip;

// Initialize a new empty ZIP archive
using (var archive = new IronZipArchive())
{
    // Add images to the archive
    archive.Add("./assets/image1.png");
    archive.Add("./assets/image2.png");

    // Save the archive to a file
    archive.SaveAs("output.zip");
}
```

## Extracting an Archive to a Folder

To extract a ZIP archive to a specific folder, use the `ExtractArchiveToDirectory` method as follows:

```cs
using IronZip;

// Unpack the ZIP file
IronZipArchive.ExtractArchiveToDirectory("output.zip", "extracted");
```

## Adding Files to an Existing Archive

To add files to an already existing ZIP archive, open it by passing its path to the constructor, then add new files as needed:

```cs
using IronZip;

// Load an existing ZIP archive
using (var archive = new IronZipArchive("existing.zip"))
{
    // Append new files to the archive
    archive.Add("./assets/image3.png");
    archive.Add("./assets/image4.png");

    // Save changes to the ZIP file
    archive.SaveAs("result.zip");
}
```

## Licensing & Support Options

IronZIP is a premium software with trial licenses available [here](https://ironsoftware.com/trial-license).

Visit [Iron Software's homepage](https://ironsoftware.com/) for more details.
For real-time assistance, please see our [live chat support](https://ironsoftware.com/#live-chat-support).

### Support from Iron Software

For general inquiries and technical support, reach out to us at: <support@ironsoftware.com>