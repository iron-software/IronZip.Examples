***Based on <https://ironsoftware.com/examples/extract-protected-zip/>***

Use IronZIP to handle encrypted ZIP files including those secured with standard, AES128, and AES256 encryption methods.

When you need to unpack a password-protected ZIP archive, use the `ExtractArchiveToDirectory` method. Here, you must provide the correct password in the **Password** parameter. Moreover, you should determine the path of the ZIP file and designate the target directory where the contents will be extracted.