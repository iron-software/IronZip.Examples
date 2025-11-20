***Based on <https://ironsoftware.com/examples/extract-bzip2/>***

BZIP2, known as the 'Burrows-Wheeler Block Sort Text Compressor,' is primarily utilized for file compression on Unix and Linux platforms. It's particularly effective for compressing text files. Despite its popularity, extracting from this format can occasionally present challenges. This is typically due to its resource-intensive nature, especially with large BZIP2 files requiring significant memory and CPU resources. In some cases, failures in extraction arise from libraries that do not support nested archives like TAR files.

IronZIP, on the other hand, provides robust support across all these formats, ensuring compatibility issues are a thing of the past. Furthermore, it operates seamlessly across all major operating systems. Below is a simple illustration of how to handle BZIP2 files using IronZIP.

<div class="examples__featured-snippet">
    <h2>Extracting BZIP2 File with C&num;</h2>
    <ol>
        <li>`using IronZip;`</li>
        <li>`IronBZip2Archive.ExtractArchiveToDirectory("output.txt.bz2", "extracted");`</li>
    </ol>
</div>

### Extracting BZIP2 Archive 

Utilizing the IronZIP namespace in any project can enhance file handling capabilities. Notably, the `IronBZIP2Archive` class provides a very useful method called `ExtractArchiveToDirectory`, which is engineered to decompress and place the contents of a BZIP2 file into a chosen directory. You need to supply the path to the BZIP2 file as the first argument and the target directory as the second.

This operation is not only efficient but also secure. Developers need to ensure that the file name includes both the original file extension and the `.bz2` suffix, due to the deletion of the file extension during the compression phase, which is also stripped away when extracting.

[Learn to Create, Read, and Extract ZIP Files with IronZip](https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/)