> Full guide: [Extract gzip](https://ironsoftware.com/csharp/zip/examples/extract-gzip/?utm_source=github)

GZIP (GNU ZIP) is widely used in Unix-like environments as a standard compression utility to reduce file size and accelerate file transfers. It's optimized for compressing individual files, which then assume a .gz extension and can be easily decompressed. For compressing multiple files, the typical approach is to aggregate them into a TAR archive, which is then compressed, yielding a file with a .tar.gz or .tgz extension.

<div class="examples__featured-snippet">
    <h2>Extracting GZIP File with C#</h2>
    <ol>
        <li>using IronZip;</li>
        <li>`IronGZipArchive.ExtractArchiveToDirectory("output.tgz", "extracted");`</li>
    </ol>
</div>

### Extracting GZIP Archive 

Utilizing the IronZIP library in our development projects offers straightforward access to its features. One key feature is the `IronGZIPArchive` class, which includes a method named `ExtractArchiveToDirectory`. This allows for the extraction of a GZIP archived file.

The `ExtractArchiveToDirectory` method in the `IronGZipArchive` class is precisely meant to decompress a GZIP file into a designated directory. The procedure requires a full path to the GZIP file as the first parameter and the target directory for extraction as the second. Developers can trust this method to be both efficient and secure.

<a href="https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/?utm_source=github" class="code_content__related-link__doc-cta-link">Discover How to Create, Read & Extract ZIP Files</a>