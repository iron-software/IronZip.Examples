> Full guide: [Create zip](https://ironsoftware.com/csharp/zip/examples/create-zip/)

The ZIP format is pivotal in archiving and file compression, merging multiple files and directories into a single file that typically carries a `.zip` suffix. This format is extensively employed for efficient data management, including backups, distributing software, and sharing files. However, manually handling multiple ZIP files or creating these archives manually can be laborious and error-prone. Leveraging IronZip simplifies this process by automating these operations and enhancing efficiency, enabling you to generate an archive in just a few lines of code.

```html
<div class="examples__featured-snippet">
    <h2>Creating a ZIP File with C#</h2>
    <ol>
        <li>using IronZip;</li>
        <li>using (var archive = new IronZipArchive())</li>
        <li>archive.Add("https://ironsoftware.com/assets/image1.jpg");</li>
        <li>archive.Add("https://ironsoftware.com/assets/example.pdf");</li>
        <li>archive.SaveAs("output.zip");</li>
    </ol>
</div>
```

### IronZip

Begin by importing the `IronZip` namespace to access the functionality of the library. Then, instantiate a new ZIP archive with the help of the `IronZipArchive` class, utilizing a 'using' construct, which facilitates the creation of an initial, blank ZIP archive.

### Adding Files to the Empty Archive

Before committing to saving, inject files into your archive using the `Add` method. This allows for the addition of various file types — from images to textual documents (like DOCX and PDF), and even audio (MP3, WAV), including other ZIP files for nested archiving.

For a detailed rundown of all supported file types that can be added, please view the detailed documentation [here](https://ironsoftware.com/csharp/zip/).

### Saving and Exporting

Conclude by committing your changes to the archive and exporting it using the `SaveAs` method, identified by the filename `'output.zip'`.

[Explore how to Read and Extract ZIP Files in C#](https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip)