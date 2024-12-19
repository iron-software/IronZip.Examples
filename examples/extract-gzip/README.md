***Based on <https://ironsoftware.com/examples/extract-gzip/>***

A TGZ file, often referred to as a "tarball," is a compressed archive type that encapsulates numerous files and directories into one container. The acronym "TGZ" originates from its two primary components: "TAR" meaning "Tape Archive," and "GZ" indicating the GZIP compression method that is applied to compress the TAR file.

To decompress and extract the contents of a TGZ file, leverage the `ExtractArchiveToDirectory` function available in the **IronGZipArchive** class. This is particularly useful when dealing with a file like 'output.tgz' that has been assembled using tar before being compressed through GZIP.