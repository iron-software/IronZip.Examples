# Tutorial on Creating, Reading, and Extracting Zip Files

***Based on <https://ironsoftware.com/tutorials/create-read-extract-zip/>***


Creating a ZIP involves generating a new archive by selecting certain files or directories, applying compression preferences, and constructing the archive.

Reading a ZIP involves opening an existing archive to access, view, or extract specific contents.

Extracting from a ZIP entails choosing the source ZIP file, defining the destination folder, and pulling files and directories into the appointed location.

IronZip extends these capabilities by allowing users to open an existing ZIP, append additional files, and save the modifications in a new ZIP archive.

<h3>Getting Started with IronZIP</h3>

---

## Example: Creating an Archive

Begin by creating a ZIP archive object in C#. This can be done neatly using a `using` statement along with the **IronZipArchive** constructor. IronZip facilitates the creation of a new, empty ZIP archive through simple code.

Subsequently, employ the `Add` method to incorporate files into your archive. This method is capable of adding files from wide-ranging sources, including whole directories.

Conclude by using the `SaveAs` method to finalize and store your ZIP file.

```cs
using IronZip;

// Instantiate an empty ZIP archive
using (var archive = new IronZipArchive())
{
    // Adding files to the archive
    archive.Add("https://ironsoftware.com/assets/image1.png");
    archive.Add("https://ironsoftware.com/assets/image2.png");

    // Saving the ZIP archive
    archive.SaveAs("output.zip");
}
```

## Example: Extracting an Archive to a Folder

To extract files from a ZIP archive, utilize the `ExtractArchiveToDirectory` method. Specify the ZIP file and the target directory for the incoming files.

```cs
using IronZip;

// Extract files from a ZIP
IronZipArchive.ExtractArchiveToDirectory("output.zip", "extracted");
```

## Example: Adding Files to an Existing Archive

Efficiently add to an existing ZIP by first accessing it through its file path, and then using the `Add` method to include additional files within.

```cs
using IronZip;

// Access an existing ZIP
using (var archive = IronZipArchive.FromFile("existing.zip"))
{
    // Append new files to the archive
    archive.Add("https://ironsoftware.com/assets/image3.png");
    archive.Add("https://ironsoftware.com/assets/image4.png");

    // Re-save the modified ZIP
    archive.SaveAs("result.zip");
}
```

This capability to modify and expand ZIP archives makes IronZip a versatile tool for managing file archives in your C# applications. IronZip simplifies the handling of archive formats such as TAR, GZIP, and BZIP2 with similar class structures like **IronTarArchive**, **IronGZipArchive**, and **IronBZip2Archive**.