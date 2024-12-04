# Using IronZip License Keys

***Based on <https://ironsoftware.com/how-to/license-keys/>***


## How to Acquire a License Key

Activating an IronZip license key enables unrestricted deployment of your project, free from watermarks or limitations.

You can [purchase a license here](https://ironsoftware.com/csharp/zip/licensing/) or obtain a [free 30-day trial key here](https://ironsoftware.com/csharp/zip/trial-license).

--------------------------------------------------------------------------------

## Step 1: Obtain the Latest IronZip Version

## Step 2: Implement Your License Key

### Implementing the license through code

Incorporate this code at the beginning of your application, prior to utilizing IronZip.

```csharp
using IronZip;
namespace ironzip.Licensing
{
    public class SetupLicense
    {
        public void Initialize()
        {
            IronZip.License.LicenseKey = "YOUR-LICENSE-KEY-HERE";
        }
    }
}
```

--------------------------------------------------------------------------------

### Applying your license in Web.Config or App.Config

For global license application using Web.Config or App.Config, insert the following entry in your configuration file under appSettings:

```xml
<configuration>
...
  <appSettings>
    <add key="IronZip.LicenseKey" value="YOUR-LICENSE-KEY-HERE"/>
  </appSettings>
...
</configuration>
```

Please be aware of a licensing problem with versions of IronZip released prior to [2024.3.3](https://www.nuget.org/packages/IronZIP/2024.3.3) in:
- **ASP.NET** projects
- **.NET Framework version >= 4.6.2**

Licenses stored in `Web.config` might not be recognized. Refer to our [guide on setting a license key in Web.config](https://ironsoftware.com/csharp/zip/troubleshooting/license-key-web.config) for more information.

Check that `IronZip.License.IsLicensed` returns `true` to confirm licensing status.

--------------------------------------------------------------------------------

### Setting the license key using a .NET Core appsettings.json file

To set a global license in a .NET Core application:

- Add an `appsettings.json` file at the root of your project.
- Include a 'IronZip.LicenseKey' key in your JSON configuration file. The value should be your license key.
- Ensure the file property is set to _Copy to Output Directory: Copy always_.

File: _appsettings.json_

```json
{
    "IronZip.LicenseKey":"YOUR-LICENSE-KEY-HERE"
}
```

--------------------------------------------------------------------------------

## Step 3: Confirming Your License Key

### Confirm the Installed License Key

To check if the license key is active, utilize the **IsLicensed** property with the following code:

```csharp
using IronZip;
namespace ironzip.Licensing
{
    public class VerifyLicense
    {
        public void Execute()
        {
            // Verify if the license key is successfully applied
            bool licensed = IronZip.License.IsLicensed;
        }
    }
}
```

### Validate the License Key

To verify the authenticity of your license or trial key, use this code snippet:

```csharp
using IronZip;
namespace ironzip.Licensing
{
    public class ValidateLicense
    {
        public void Execute()
        {
            // Validate the provided license key string
            bool valid = IronZip.License.IsValidLicense("YOUR-LICENSE-KEY-HERE");
        }
    }
}
```

If `valid` is **True**, the key is legitimate and you can proceed with using IronZIP. If it's **False**, the key is incorrect.

--------------------------------------------------------------------------------

## Step 4: Getting Started with Your Project

To begin with IronZIP, it's recommended to follow our detailed tutorial on [how to Get Started with IronZip](https://ironsoftware.com/csharp/zip/docs/). This tutorial provides comprehensive instructions and examples for understanding the essentials of IronZip.

--------------------------------------------------------------------------------

## Questions or Require Support?

For deploying IronZip in your live projects, a paid or trial license key is necessary, available through [purchasing a license](https://ironsoftware.com/csharp/zip/licensing/) or [visiting this trial link](https://ironsoftware.com/csharp/zip/trial-license).

Explore a variety of code examples, tutorials, licensing information, and detailed documentation on our [IronZIP webpage](https://ironsoftware.com/csharp/zip/).

For any inquiries, please contact <support@ironsoftware.com>.