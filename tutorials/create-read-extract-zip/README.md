# Create, Read, and Extract Zip Tutorial

> Full guide: [Create, Read, and Extract Zip Tutorial](https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/?utm_source=github)

Creating a ZIP involves generating a new ZIP archive by selecting files or directories, defining compression settings, and finalizing the archive creation.

Reading a ZIP provides access to the contents of an existing ZIP archive, allowing for file viewing or selective extraction.

Extracting from a ZIP consists of pulling out files by determining the source ZIP file, designating a destination folder, and moving files and directories to the intended location.

IronZip further enhances these capabilities by allowing users to open and add additional files to an existing ZIP and then save it as a new ZIP that includes all the adjusted content.

<h3>Get Started with IronZIP</h3>

-----

## Example of Creating an Archive

To initiate a ZIP archive object in C#, apply the `using` statement with the `IronZipArchive` constructor. IronZip offers a simplified method to construct an empty ZIP archive.

Following that step, use the `Add` method to load files into the ZIP archive from various sources, including entire directories.

Conclude with the `SaveAs` method to finalize and export the ZIP archive.

```csharp
using IronZip;

// Initialize an empty ZIP
using (var archive = new IronZipArchive())
{
    // Include files in the ZIP
    archive.Add("./assets/image1.png");
    archive.Add("./assets/image2.png");

    // Complete the ZIP file creation
    archive.SaveAs("output.zip");
}
```

## Extract an Archive to a Folder

To extract files from a ZIP archive, utilize the `ExtractArchiveToDirectory` method. Just provide the ZIP file path and the destination directory for the extracted contents.

```csharp
using IronZip;

// Unzip the archive
IronZipArchive.ExtractArchiveToDirectory("output.zip", "extracted");
```

## Enhance an Existing Archive with Additional Files

You can easily augment an existing ZIP archive by adding new files using IronZip. Begin by loading the ZIP archive from a file, then employ the `Add` method to include new files.

```csharp
using IronZip;

// Access an existing ZIP
using (var archive = IronZipArchive.FromFile("existing.zip"))
{
    // Insert more files
    archive.Add("./assets/image3.png");
    archive.Add("./assets/image4.png");

    // Update the ZIP archive
    archive.SaveAs("result.zip");
}
```

IronZip simplifies the process of managing and updating ZIP archives in your C# projects, accommodating the dynamic needs of any project.

IronZip's methodology is also applicable to handling other archive types like TAR, GZIP, and BZIP2 through the use of the `IronTarArchive`, `IronGZipArchive`, and `IronBZip2Archive` classes respectively.