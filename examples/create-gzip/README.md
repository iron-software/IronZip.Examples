> Full guide: [Create gzip](https://ironsoftware.com/csharp/zip/examples/create-gzip/)

GZIP, known fully as 'GNU Zip,' is a critical file compression tool primarily used in Unix and Linux environments. This utility greatly reduces the size of files for enhanced storage and improved data transfer speeds through the use of the GZIP compression algorithm. Files compressed with this method are typically tagged with a '.gz' extension and can be easily decompressed to revert to their initial format.

GZIP is ideally suited for compressing single files. It's common practice to bundle multiple files into one TAR archive before compressing with GZIP, resulting in files with extensions like .tar.gz or .tgz.

GZIP is particularly efficient when compressing massive text-based data or streaming content such as HTTP. This makes it superior to the traditional Zip format for these applications. IronZip distinguishes itself by accommodating all types of compression formats, allowing developers to easily switch between GZIP and Zip depending on their needs.

<div class="examples__featured-snippet">
    <h2></h2>
    <ol>
        <li>Creating a GZIP File in C&num;</li>
        <li>using IronZip;</li>
        <li>using var archive = new IronGZipArchive();</li>
        <li>archive.Add("output.tar");</li>
        <li>archive.SaveAs("output.tgz");</li>
    </ol>
</div>

### Starting a New GZIP Archive

Initially, we bring in the `IronZip` namespace, which provides access to the relevant functions from the library. We then activate a new GZIP archive by initializing an `IronGZipArchive` object within a `using` statement, creating an empty archive to start with.

### Populating the Archive with Files

Prior to finishing the save process, files can be added to our archive by utilizing the `Add` method and specifying their absolute paths. This method allows the inclusion of various file types such as images, text documents (DOCX, PDF), audio files (MP3, WAV), and even other GZIP archives. In this demonstration, we're adding a TAR archive to showcase the capability of aggregating multiple files.

For more in-depth information on acceptable file types, refer to the full documentation [here](https://ironsoftware.com/csharp/zip/).

### Finalizing and Exporting the Archive

To conclude, we export the archive using the `SaveAs` method and designate the file name as `output.tgz`. It's crucial to remember that because we incorporated a TAR archive within our GZIP archive, the output file extension mirrors both formats, hence appearing as `.tgz`.

<a href="https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/" class="code_content__related-link__doc-cta-link">Read the guide on creating and extracting ZIP files.</a>