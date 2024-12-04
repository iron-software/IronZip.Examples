***Based on <https://ironsoftware.com/examples/create-gzip/>***

GZIP, often referred to as 'GNU Zip,' serves as a file compression utility prevalent in Unix and Linux environments. It leverages the GZIP compression algorithm to diminish file sizes, enabling more efficient storage and swifter data transmission. Files compressed using GZIP are marked by a '.gz' extension and can be restored to their original form with ease.

Typically, GZIP is employed to compress single files. A regular approach involves grouping several files into a single TAR archive, followed by compressing this archive using GZIP. The associated file gets extensions like `.tar.gz` or `.tgz`.

In the snippet provided, the **IronGZipArchive** class is initialized within a `using` block. Employ the `Add` method to incorporate the TAR file into the GZIP archive. To finalize and store the compressed file, use the `SaveAs` method.