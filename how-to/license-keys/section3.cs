using IronZip;
namespace IronZip.Examples.HowTo.LicenseKeys
{
    public static class Section3
    {
        public static void Run()
        {
            // Check if a given license key string is valid
            bool valid = IronZip.License.IsValidLicense("IRONZIP.MYLICENSE.KEY.1EF01");
        }
    }
}