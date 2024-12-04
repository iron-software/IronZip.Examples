***Based on <https://ironsoftware.com/examples/extract-gzip/>***

A TGZ file, often referred to as a "tarball," consolidates several files and directories into one archive. The term "TGZ" originates from its two key elements: "TAR," which abbreviates "Tape Archive," and "GZ," indicating the GZIP compression that is applied to compress the tar archive.

To decompress and extract a TGZ file, you can utilize the `ExtractArchiveToDirectory` method from the `IronGZipArchive` class. The file 'output.tgz' is initially assembled using tar and subsequently compressed using GZIP compression.