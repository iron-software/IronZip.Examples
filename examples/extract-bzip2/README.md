***Based on <https://ironsoftware.com/examples/extract-bzip2/>***

BZIP2, also known as the 'Burrows-Wheeler Block Sort Text Compressor,' is a compression tool widely utilized in Unix and Linux environments. It is primarily optimized for compressing single text files.

To decompress files within a BZIP2 archive, employ the `ExtractArchiveToDirectory` static method provided by the **IronBZip2Archive** class. This method demands the path of the BZIP2 file as its first argument and the target directory for extraction as the the second. Notice that the filename should include both its original file extension and the .bz2 extension. The process of compression strips away the original extension, which is automatically removed by the method during the extraction process.