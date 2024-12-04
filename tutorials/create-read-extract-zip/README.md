# Create, Read, and Extract Zip Tutorial

***Based on <https://ironsoftware.com/tutorials/create-read-extract-zip/>***


Creating a ZIP involves generating a new ZIP archive by choosing files or folders, setting the compression preferences, and then assembling the actual archive.

Reading a ZIP allows you to open an existing ZIP archive to view or extract specific files as needed.

Extracting from a ZIP involves selecting the source ZIP file and the target directory, then unpacking the files and directories into that location.

In addition to these functionalities, with IronZip, you can open an already existing ZIP file, incorporate additional files, and then save it as a new ZIP file that includes all the items.

## Example: Creating a ZIP Archive

To initiate a ZIP archive, you can simply use the `using` statement in C# along with the **IronZipArchive** constructor. IronZip simplifies this procedure, enabling you to start an empty ZIP archive with minimal coding.

Then, employ the `Add` method to integrate your files into the ZIP archive. This allows inclusion of files from different locations, including all files within a specified directory.

Finish by using the `SaveAs` method to output the ZIP file.

```cs
using IronZip;
namespace ironzip.CreateReadExtractZip
{
    public class Section1
    {
        public void Run()
        {
            // Initialize an empty ZIP archive
            using (var archive = new IronZipArchive())
            {
                // Add specific files to the archive
                archive.Add("https://ironsoftware.com/assets/image1.png");
                archive.Add("https://ironsoftware.com/assets/image2.png");
            
                // Write the ZIP file to disk
                archive.SaveAs("output.zip");
            }
        }
    }
}
```

## Extracting Files from an Archive to a Folder

To access the files in a ZIP archive, utilize the `ExtractArchiveToDirectory` method. Simply specify the ZIP file's path and the target directory for the extracted files.

```cs
using IronZip;
namespace ironzip.CreateReadExtractZip
{
    public class Section2
    {
        public void Run()
        {
            // Unpack the ZIP contents
            IronZipArchive.ExtractArchiveToDirectory("output.zip", "extracted");
        }
    }
}
```

## Adding Files to an Existing Archive

Modifying an existing ZIP archive by adding more files is made easy with IronZip. Start by creating an archive object from an existing ZIP file. After opening it, files can be added using the `Add` method.

```cs
using IronZip;
namespace ironzip.CreateReadExtractZip
{
    public class Section3
    {
        public void Run()
        {
            // Access an existing ZIP
            using (var archive = IronZipArchive.FromFile("existing.zip"))
            {
                // Incorporate additional files
                archive.Add("https://ironsoftware.com/assets/image3.png");
                archive.Add("https://ironsoftware.com/assets/image4.png");
            
                // Save the updated archive
                archive.SaveAs("result.zip");
            }
        }
    }
}
```

This feature enables effective updating and expansion of your ZIP archives, which is crucial for adapting to the dynamic requirements of your projects. Furthermore, similar operations are possible for other archive types such as TAR, GZIP, and BZIP2 through the use of **IronTarArchive**, **IronGZipArchive**, and **IronBZip2Archive** classes.