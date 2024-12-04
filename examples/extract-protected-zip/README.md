***Based on <https://ironsoftware.com/examples/extract-protected-zip/>***

Employ IronZIP to unpack encrypted ZIP archives, including those secured with normal, AES128, and AES256 encryption.

To accomplish the extraction of a secured ZIP file, it's essential to provide the accurate password for the **Password** parameter within the `ExtractArchiveToDirectory` method. You should also define the ZIP file's path and the destination directory where the contents will be extracted.