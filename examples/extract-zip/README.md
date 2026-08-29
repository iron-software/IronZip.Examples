> Full guide: [Extract zip](https://ironsoftware.com/csharp/zip/examples/extract-zip/?utm_source=github)

ZIP is a compression format used to consolidate multiple files and directories into a single file, usually with a '.zip' extension. This format is especially useful for reducing file size and organizing data, making it ideal for tasks like software distribution, file sharing, and data backup.

Managing the extraction of ZIP files, particularly in bulk, could become challenging and error-prone when done manually. IronZIP, however, simplifies this process by allowing for the automated extraction of contents from ZIP archives, enhancing workflow efficiency.

<div class="examples__featured-snippet">
    <h2>Extracting a ZIP File Using C#</h2>
    <ol>
        <li>using IronZip;</li>
        <li>IronZipArchive.ExtractArchiveToDirectory("output.zip", "extracted");</li>
    </ol>
</div>

### Extracting a ZIP Archive 

Initially, incorporate the `IronZip` namespace to employ its functionalities. Next, utilize the `ExtractArchiveToDirectory` method to unload the contents of the ZIP file into the desired directory.

This function performs the extraction by taking two parameters: the first is the path to the ZIP file from which contents are to be extracted, and the second is the target directory for the extracted files. It's important to note that the path to the ZIP file needs to be specified absolutely.

<a href="https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/?utm_source=github" class="code_content__related-link__doc-cta-link">Learn to Create and Extract ZIP Files with IronZip</a>