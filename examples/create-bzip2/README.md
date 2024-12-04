***Based on <https://ironsoftware.com/examples/create-bzip2/>***

BZIP2, short for 'Burrows-Wheeler Block Sort Text Compressor,' is a compression tool utilized on Unix and Linux platforms. It effectively reduces the size of files through the application of the BZIP2 compression algorithm, typically yielding files that end with the '.bz2' extension. It is praised for its superior compression capability, making it a popular choice for both software distribution and data archiving purposes.

Unlike a file archiver which combines multiple files and directories into a single archived file, BZIP2 is tailored for the compression of individual files. It excels in the compression of textual data, offering relatively swift decompression.

In utilizing the BZIP2 format, it's essential that the resultant file has the '.bz2' extension to ensure it can be decompressed into a text file at a later time. Within a `using` block, utilize the `Add` method to incorporate a text file into the final BZIP2 archive. Conclude by employing the `SaveAs` method to generate the `BZIP2` file.