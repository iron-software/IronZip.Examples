> Full guide: [Extract tar](https://ironsoftware.com/csharp/zip/examples/extract-tar/)

TAR files are widely acknowledged for their ability to consolidate numerous files and directories into a single archive while also compressing them. However, extracting these archives can prove challenging, especially because they often integrate with GZIP and BZIP2 formats. Yet, using the capabilities of IronZIP, one can utilize the **IronTarArchive** class for extracting TAR contents efficiently, thereby managing multiple compression layers within a unified library framework.

<div class="examples__featured-snippet">
    <h2>Extracting TAR File with C#</h2>
    <ol>
        <li>`using IronZip;`</li>
        <li>`IronTarArchive.ExtractArchiveToDirectory("output.tar", "extracted");`</li>
    </ol>
</div>

### Extracting TAR Archive 

Initially, integrate the **IronZip** namespace into your project to tap into its rich feature set. The **IronTarArchive** class is specifically designed for extracting TAR file contents through the **ExtractArchiveToDirectory** method.

This method efficiently decompresses the contents from a TAR file into a targeted directory. You need to provide the complete path of the TAR file as the first argument. The second argument should specify the target directory where the extracted files will be stored.

[Learn to Create, Read, and Extract ZIP Files](https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/){.code_content__related-link__doc-cta-link}