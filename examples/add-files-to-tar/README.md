***Based on <https://ironsoftware.com/examples/add-files-to-tar/>***

Many find the usual process of adding new files to existing TAR archives cumbersome. Typically, you must extract the entire contents, add new files, and recompress everything into a new archive. This method is not only tedious but can also consume a significant amount of time, particularly when managing multiple TAR files.

IronZIP introduces a more streamlined approach that can significantly reduce both time and effort. It comes equipped with an intuitive **Add** method, allowing users to easily integrate new files into existing TAR archives without the need for extraction. In the example below, we demonstrate the simplicity of the **Add** method, showing how it facilitates file addition efficiently. Embrace this more effective method to enhance your TAR archive management!

<div class="examples__featured-snippet">
    <h2>Add Files to TAR with C#</h2>
    <ol>
        <li>using IronZip;</li>
        <li>using (var archive = IronTarArchive.FromFile("existing.tar"))</li>
        <li>archive.Add("https://ironsoftware.com/assets/image3.png");</li>
        <li>archive.Add("https://ironsoftware.com/assets/image4.png");</li>
        <li>archive.SaveAs("result.tar");</li>
    </ol>
</div>

### Accessing Existing TAR to Add Files

First, we import the namespace **IronZip**. Then, we initialize a new **IronTarArchive** and use the **FromFile** method to open the existing TAR.

### Adding Files

After accessing the TAR, new files can be added with the **Add** method. This method requires just one parameter: the file path of the file you wish to add. If the path is incorrect, the operation will fail. In our example, we add two images, **image3.png** and **image4.png**, to the TAR using the **Add** method.

IronZIP supports a variety of file formats in addition to PNG. It can handle popular image formats like JPG and SVG, and multi-frame formats such as TIFF and GIF. For text and audio files, IronZIP manages PDFs, DOCX, XLSX, as well as audio formats including MP3 and WAV. Amazingly, it even allows adding TAR files within another TAR, providing immense flexibility. For an extensive list of compatible file types, please visit [here](https://ironsoftware.com/csharp/zip/).

#### Exporting the TAR

Finally, once the files are added to the existing TAR archive, use the **SaveAs** function to name the new TAR archive that now contains the newly added files.

[Learn how to Create, Read, and Extract ZIP Files in C#](https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/)