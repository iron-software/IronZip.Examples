> Full guide: [Extract protected zip](https://ironsoftware.com/csharp/zip/examples/extract-protected-zip/)

IronZIP provides functionality to extract ZIP archives, including those secured with general, AES128, or AES256 encryption. This flexibility makes it straightforward to handle a variety of ZIP files, from minimally secured to heavily encrypted ones. The library is designed to be integrated seamlessly into existing applications or used as a standalone tool for critical operations.


<div class="examples__featured-snippet">
    <h2>Unpacking Protected Zip Files with C#</h2>
    <ol>
        <li>using IronZip;</li>
        <li>IronZipArchive.ExtractToDirectory("secured.zip", "outputFolder", "SecureP@ss");</li>
    </ol>
</div>

### Unpacking a Zip File

Initially, integrate the `IronZip` namespace into your project to access its capabilities. Employ the `ExtractToDirectory` method to unpack a ZIP file to a chosen directory.

This method helps you transfer the contents of a ZIP file into a specified folder. The first argument should be the path to the ZIP file you wish to unpack. The second argument is the directory where you want the files to be extracted. If the ZIP file is secure with a password, the extraction will require the correct password in the third argument; failing to provide the correct password will trigger a runtime error and stop the extraction.

<a href="https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/" class="code_content__related-link__doc-cta-link">Discover How to Create & Unpack ZIP Files Using IronZip</a>
