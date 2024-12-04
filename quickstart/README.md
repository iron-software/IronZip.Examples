# Introduction to IronZIP

***Based on <https://ironsoftware.com/docs/docs/>***


## Overview

**IronZIP** is a versatile library for managing archive formats like ZIP, TAR, GZIP, and BZIP2, crafted by the experts at Iron Software.

### Compatibility

**IronZIP** offers compatibility across a variety of platforms and technologies:

#### Supported .NET Versions:

- **C#**, **VB.NET**, **F#**
- **.NET 7, 6**, 5, and Core 3.1+
- .NET Standard (2.0+)
- .NET Framework (4.6.2+)

#### Supported Operating Systems and Environments:

- **Windows** (10+, Server 2016+)
- **Linux** (Ubuntu, Debian, CentOS, and more)
- **macOS** (10+)
- **iOS** (12+)
- **Android** API 21+ (v5 “Lollipop”)
- **Docker** (Windows, Linux, Azure)
- **Azure** (VPS, WebApp, Function)
- **AWS** (EC2, Lambda)

#### Supported .NET Project Types:

- **Web** (Blazor & WebForms)
- **Mobile** (Xamarin & MAUI)
- **Desktop** (WPF & MAUI)
- **Console** (App & Library)

## Getting IronZIP

### Installation Steps

To install the **IronZIP** library, simply execute the following command:

```shell
Install-Package IronZip
```

You can also acquire it directly from the [official IronZIP NuGet website](https://www.nuget.org/packages/IronZip).

Once installed, initiate your projects by adding `using IronZip;` at the beginning of your C# scripts.

## License Key Activation

To activate IronZIP, apply a valid license or trial key as follows, ensuring to perform this before invoking any library methods:

```cs
using IronZip;
namespace ironzip.Quickstart
{
    public class Section1
    {
        public void Run()
        {
            IronZip.License.LicenseKey = "IRONZIP.MYLICENSE.KEY.1EF01";
        }
    }
}
```

## Practical Examples

### Creating an Archive Example

Employ the `AddArchiveEntry` method within a `using` block to produce a ZIP archive and populate it with files. Subsequently, deploy the `SaveAs` method to output the archive:

```cs
using IronZip;
namespace ironzip.Quickstart
{
    public class Section2
    {
        public void Run()
        {
            // Start a new ZIP
            using (var archive = new IronZipArchive())
            {
                // Insert files into the ZIP
                archive.Add("./assets/image1.png");
                archive.Add("./assets/image2.png");
            
                // Finalize the ZIP file
                archive.SaveAs("output.zip");
            }
        }
    }
}
```

### Extracting an Archive

Utilize the `ExtractArchiveToDirectory` to extract a ZIP file into a specified directory:

```cs
using IronZip;
namespace ironzip.Quickstart
{
    public class Section3
    {
        public void Run()
        {
            // Unpack ZIP contents
            IronZipArchive.ExtractArchiveToDirectory("output.zip", "extracted");
        }
    }
}
```

### Adding Files to an Existing Archive

To augment an existing ZIP file, open it and add new files using `AddArchiveEntry`, finishing with `SaveAs` to export the amended archive:

```cs
using IronZip;
namespace ironzip.Quickstart
{
    public class Section4
    {
        public void Run()
        {
            // Load an existing ZIP
            using (var archive = new IronZipArchive("existing.zip"))
            {
                // Enhance the ZIP with new files
                archive.Add("./assets/image3.png");
                archive.Add("./assets/image4.png");
            
                // Dispatch the enhanced ZIP
                archive.SaveAs("result.zip");
            }
        }
    }
}
```

## Licensing & Getting Support

**IronZIP** is a proprietary library, although free trial licenses are available [here](https://ironsoftware.com/trial-license).

Visit [Iron Software's website](https://ironsoftware.com/) for more details.
For support or inquiries, reach out to our team via our [live chat support](https://ironsoftware.com/#live-chat-support) service.

### Support Services from Iron Software

For general queries or technical support, please contact us at: <support@ironsoftware.com>