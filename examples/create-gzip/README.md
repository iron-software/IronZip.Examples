***Based on <https://ironsoftware.com/examples/create-gzip/>***

GZIP, an abbreviation for 'GNU Zip,' is a compression tool utilized primarily in Unix and Linux environments. This utility compresses files to minimize their size for more efficient storage and quicker data transfer, implementing the GZIP compression method. The files compressed by GZIP have a `.gz` extension and can be restored to their original condition seamlessly.

It is standard practice to use GZIP for compressing single files. Often, multiple files are combined into one TAR archive before being compressed with GZIP. The files that undergo this double compression have file names ending in `.tar.gz` or `.tgz`.

In the example provided, you can initialize the `IronGZipArchive` class through the `using` statement. To add files into the GZIP archive, utilize the `Add` method for the TAR file. Finally, employ the `SaveAs` method to output the compressed GZIP file.