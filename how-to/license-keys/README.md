# Utilizing IronZip License Keys

***Based on <https://ironsoftware.com/how-to/license-keys/>***


## Obtaining a License Key

Incorporating an IronZip license key enables you to run your project live free from any limitations or watermark impositions.

You can [purchase a license here](https://ironsoftware.com/csharp/zip/licensing/) or register for a [free 30-day trial key](trial-license).

--------------------------------------------------------------------------------

## Step 1: Acquire the Latest IronZip Version

## Step 2: Implement Your License Key

### Setting the license via code

Include this code at the beginning of your application, prior to utilizing IronZip.

```csharp
IronZip.License.LicenseKey = "IRONZIP.MYLICENSE.KEY.1EF01";
```

--------------------------------------------------------------------------------

### Implementing the license through Web.Config or App.Config

For a broad application of your key using Web.Config or App.Config, insert the following entry into your configuration file under appSettings.

```xml
<configuration>
...
  <appSettings>
    <add key="IronZip.LicenseKey" value="IRONZIP.MYLICENSE.KEY.1EF01"/>
  </appSettings>
...
</configuration>
```

Be aware of a licensing issue with IronZip versions prior to [2024.3.3](https://www.nuget.org/packages/IronZIP/2024.3.3) concerning:
- **ASP.NET** projects
- **.NET Framework version >= 4.6.2**

For this problem, the `Web.config` key is **NOT** utilized by the software. Consult the '[Resolving License Key Issues in Web.config](https://ironsoftware.com/csharp/zip/troubleshooting/license-key-web.config/)' guide for further details.

Check that `IronZip.License.IsLicensed` evaluates to `true` to confirm license application.

--------------------------------------------------------------------------------

### Setting your license key via a .NET Core appsettings.json file

To globally apply your key in a .NET Core environment:

- Insert a JSON file named appsettings.json in your project's root directory.
- Insert the 'IronZip.LicenseKey' in your JSON configuration file, setting it to your license key.
- Set the file property _Copy to Output Directory_ to _Copy always_.

File: _appsettings.json_

```json
{
    "IronZip.LicenseKey":"IRONZIP.MYLICENSE.KEY.1EF01"
}
```

--------------------------------------------------------------------------------

## Step 3: Confirm Your License Key

### Checking the Installed License Key

To confirm the license key installation, check the `IsLicensed` attribute using this code snippet:

```csharp
// Confirm the license application
bool licensed = IronZip.License.IsLicensed;
```

### Validating the License Key

To verify your license's or trial key's validity, employ this code snippet:

```csharp
// Validate the specified license key
bool valid = IronZip.License.IsValidLicense("IRONZIP.MYLICENSE.KEY.1EF01");
```

If the returned value is **True**, your key is valid and you are set to use IronZIP. Conversely, a **False** return signifies an invalid key.

--------------------------------------------------------------------------------

## Step 4: Launching Your Project with IronZIP

To begin with IronZIP, we strongly suggest following our detailed tutorial on how to [Get Started with IronZip](https://ironsoftware.com/csharp/zip/docs/). This tutorial provides comprehensive instruction and examples enhancing your understanding of IronZip operations.

--------------------------------------------------------------------------------

## Questions or Require Assistance?

When deploying IronZip in live projects, obtaining a paid or trial license key is necessary and is available through [purchasing a license](https://ironsoftware.com/csharp/zip/licensing/) or by visiting [this page for a trial license](trial-license).

For a wealth of code examples, tutorials, licensing information, and detailed documentation, refer to the [IronZIP section](https://ironsoftware.com/csharp/zip/) on our website.

For further inquiries, please contact <support@ironsoftware.com>.