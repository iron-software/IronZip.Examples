***Based on <https://ironsoftware.com/examples/extract-bzip2/>***

BZIP2, also known as 'Burrows-Wheeler Block Sort Text Compressor,' is a popular compression tool predominantly used on Unix and Linux platforms. It's primarily optimized for compressing text files.

To decompress files from a BZIP2 archive, you can use the static `ExtractArchiveToDirectory` method from the **IronBZip2Archive** class. This method takes two parameters: the path to the BZIP2 file as the first parameter, and the directory for extraction as the second. It's important to remember that the full filename should include both the original file's extension and the .bz2 extension. The method is designed to strip the .bz2 extension during the decompression process.