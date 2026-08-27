> Full guide: [Add files to zip](https://ironsoftware.com/csharp/zip/examples/add-files-to-zip/)

When managing multiple ZIP archives, adding new files typically involves a laborious process: you extract the contents of the archive, include the new files, and then re-compress everything back into a new ZIP. This method is time-intensive and inefficient.

A preferable approach is to utilize a specialized library designed for direct manipulation of ZIP files. **IronZip** is particularly adept in this area, featuring a robust **Add** method that lets you add new files directly to existing ZIP archives, thereby bypassing the need to extract them first. Here is a quick guide on how to use this feature effectively with a practical C# example.

```html
<div class="examples__featured-snippet">
    <h2>Add Files to ZIP with C&num;</h2>
    <ol>
        <li>`using IronZip;`</li>
        <li>`using (var archive = IronZipArchive.FromFile("existing.zip"))`</li>
        <li>`archive.Add("./assets/image3.png");`</li>
        <li>`archive.Add("./assets/image4.png");`</li>
        <li>`archive.SaveAs("result.zip");`</li>
    </ol>
</div>
```

### Accessing an Existing ZIP to Add Files

Start by importing the **IronZip** namespace and then create an instance of **IronZipArchive**. We do this using the **FromFile** method, which opens the ZIP archive from the specified path. Ensure the path is accurate to avoid any operational failings.

### Adding Files 

Once the ZIP file is accessible, you can proceed to add new files. Invoke the **Add** method, specifying the path to the file you want to add. This operation requires accurate paths to avoid errors. In our example, we add two image files named **image3.png** and **image4.png** to the archive.

IronZIP is versatile, supporting a variety of file formats besides PNG. It can handle popular image formats such as JPG, SVG, multi-frame images like TIFF and GIF, and other file types such as text documents, PDFs, DOCX, XLSX files, and audio files like MP3 and WAV. It even supports embedding ZIP files within another ZIP. For details on all supported file types, see [this comprehensive file list](https://ironsoftware.com/csharp/zip/).

#### Exporting the ZIP

After all files are added, finalize the archive by using the **SaveAs** method to name and save the new ZIP file containing the updated contents.

For additional insights on how to create, read, and extract ZIP archives using IronZip, visit [this detailed tutorial](https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/).