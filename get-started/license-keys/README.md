# Utilizing IronZIP License Keys

***Based on <https://ironsoftware.com/get-started/license-keys/>***


## Obtaining a License Key

To deploy projects using IronZIP without any limitations or watermarks, obtaining a license key is essential.

You may [purchase a license key here](https://ironsoftware.com/csharp/zip/licensing/) or opt for a [free trial key that lasts for 30 days](https://ironsoftware.com/trial-license).

--------------------------------------------------------------------------------

## Step 1: Acquire the Newest IronZIP Version

[Download the most recent IronZIP version from its official source](https://ironsoftware.com/csharp/zip/).

## Step 2: Implementing Your License Key

### Incorporating your license through code

Implement the following code snippet at the beginning of your application, prior to utilizing IronZIP.

```csharp
// THIS CODE SNIPPET IS NOT AVAILABLE!
```

--------------------------------------------------------------------------------

### Applying your license via Web.Config or App.Config

To globally set your license for IronZIP within your application using Web.Config or App.Config, insert the following within your config file under appSettings.

```xml
<configuration>
  ...
  <appSettings>
    <add key="IronZIP.LicenseKey" value="IRONZIP.MYLICENSE.KEY.1EF01"/>
  </appSettings>
  ...
</configuration>
```

Issues exist with IronZIP versions before [2024.3.3](https://www.nuget.org/packages/IronZIP/2024.3.3) regarding license recognition in:
- **ASP.NET** projects
- **.NET Framework version >= 4.6.2**

Your `Web.config` file might not correctly apply the license key. See this article for assistance: ['Setting License Key in Web.config'](https://ironsoftware.com/csharp/zip/troubleshooting/license-key-web.config/).

Always check if `IronZip.License.IsLicensed` returns `true` to confirm licensing.

--------------------------------------------------------------------------------

### Setting your license key in a .NET Core app via appsettings.json

For a global application of the key within a .NET Core setup:

- Create a `appsettings.json` in your project's root.
- Add your license key as shown below:
- Set _Copy to Output Directory_ to _Copy always_ for this file.

File: _appsettings.json_

```json
{
    "IronZip.LicenseKey":"IRONZIP.MYLICENSE.KEY.1EF01"
}
```

--------------------------------------------------------------------------------

## Step 3: Confirming Your License Key

### Confirming the Installed License

To check if the license key is properly installed, review the **IsLicensed** property using the following code:

```csharp
// THIS CODE SNIPPET IS NOT AVAILABLE!
```

### Checking License Validity

Ensure your license or trial key is valid with the next code snippet:

```csharp
// THIS CODE SNIPPET IS NOT AVAILABLE!
```

A return of **True** signals an active, valid key, while **False** indicates an issue with the key.

--------------------------------------------------------------------------------

## Step 4: Starting Your Project with IronZIP

Begin your work with IronZIP by engaging with our detailed tutorial on [How to Get Started with IronZip](https://ironsoftware.com/csharp/zip/docs/). This guide provides essential instructions and tips for first-time users.

--------------------------------------------------------------------------------

## Assistance and Support

For deployment in live projects, a valid license—either purchased or trial—is required. You can [get your license here](https://ironsoftware.com/csharp/zip/licensing/) and access your trial at [this link](https://ironsoftware.com/trial-license). A wealth of resources, including tutorials, licensing information, and extensive documentation, is available in our [IronZIP portal](https://ironsoftware.com/csharp/zip/).

For any queries, please contact <support@ironsoftware.com>.