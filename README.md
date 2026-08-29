# IronZip.Examples

Runnable C# examples for [IronZip](https://ironsoftware.com/csharp/zip/?utm_source=github), a .NET archive library that creates, reads, and extracts ZIP, TAR, GZIP, and BZIP2 archives with password protection and configurable compression.

## Install

```bash
dotnet add package IronZip
```

## Quickstart

```csharp
using IronZip;

License.LicenseKey = "YOUR-LICENSE-KEY";

// Create a ZIP and add files to it
using (var archive = new IronZipArchive())
{
    archive.Add("./assets/image1.jpg");
    archive.Add("./assets/image2.jpg");
    archive.SaveAs("output.zip");
}

// Extract it again
IronZipArchive.ExtractArchiveToDirectory("output.zip", "extracted");
```

`new IronZipArchive(9)` sets the compression level, and `new IronZipArchive("existing.zip")` opens an archive already on disk so you can list `Entries()` or add more files. `archive.Encrypt("P@ssw0rd", EncryptionMethods.Traditional)` protects the archive; AES128 and AES256 are also available. `IronTarArchive`, `IronGZipArchive`, and `IronBZip2Archive` follow the same shape for the other formats.

Note that `ExtractArchiveToDirectory` is **static** — it is called on the type, not on an instance.

For production use, set a license key via `License.LicenseKey = "YOUR-KEY"`.

## What's in this repo

Each folder contains a self-contained .NET project you can open and run:

- `examples/` — focused snippets demonstrating individual features
- `get-started/` — license-key setup
- `quickstart/` — an end-to-end project scaffold
- `tutorials/` — a longer create, read, and extract walkthrough

## Common tasks covered

- Creating ZIP, TAR, GZIP, and BZIP2 archives
- Adding individual files and whole directories to an archive
- Opening an existing archive and appending to it
- Listing archive entries by name
- Extracting an archive to a directory
- Password protection with Traditional, AES128, and AES256 encryption
- Opening and extracting a password-protected archive
- Setting the compression level from 0 to 9

## Platform support

.NET Standard 2.0 — so .NET 8, 7, 6, 5, .NET Core 2.0+, and .NET Framework 4.6.1+. Windows, macOS, Linux, Docker, Azure, and AWS. See the [documentation](https://ironsoftware.com/csharp/zip/docs/?utm_source=github) for environment-specific notes.

## Documentation and support

- Full documentation: [ironsoftware.com/csharp/zip/docs](https://ironsoftware.com/csharp/zip/docs/?utm_source=github)
- API reference: [ironsoftware.com/csharp/zip/object-reference/api](https://ironsoftware.com/csharp/zip/object-reference/api/?utm_source=github)
- Issues with these examples: file directly on this repository
- Product support: [support@ironsoftware.com](mailto:support@ironsoftware.com)

## About

This repository is maintained by [Iron Software](https://ironsoftware.com/?utm_source=github). IronZip is a commercial library — see [licensing](https://ironsoftware.com/csharp/zip/licensing/?utm_source=github) for terms and trial details.
